using Api.Core.Domain;
using Api.Helper;
using Api.Model;
using Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/authenticate")]
    public class Authenticate1Controller : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        public Authenticate1Controller(UserManager<ApplicationUser> userManager, IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            this.userManager = userManager;
            this._configuration = configuration;
            this._unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModelWithName model)
        {
            var user = await userManager.FindByNameAsync(model.Username);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString())
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return StatusCode(StatusCodes.Status401Unauthorized, new Response { Status = "Error", Message = "Invalid username or password" });

        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                string errorStr = string.Empty;
                foreach (var error in result.Errors)
                {
                    if (string.IsNullOrEmpty(errorStr))
                    {
                        errorStr = error.Description;
                    }
                    else
                    {
                        errorStr += "\n " + error.Description;
                    }
                }
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = errorStr });
            }

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        //[HttpPost]
        //[Route("user")]
        //public async Task<IActionResult> GetUser()
        //{
        //    try
        //    {
        //        var user = await _unitOfWork.User.GetAll();
        //        return Ok(user);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
            
        //}

    }
}
