using Api.Core.Domain;
using Api.Model;
using Api.Service;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Api.Controllers.v1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/user")]
    public class User1Controller : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        public User1Controller(
            UserManager<ApplicationUser> userManager,
            //IConfiguration configuration,
            IUnitOfWork unitOfWork
            )
        {
            this._userManager = userManager;
            //this._configuration = configuration;
            this._unitOfWork = unitOfWork;
        }

        [Route("add")]
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel model)
        {
            var userExists = await _userManager.FindByEmailAsync(model.EmailId);
            if (userExists != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            }

            var username = GetRandomAlphanumericString(7);

            ApplicationUser user = new ApplicationUser()
            {
                Email = model.EmailId,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = username
            };
            var result = await _userManager.CreateAsync(user, "Pass@123");
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
            else
            {
                var getuser = await _userManager.FindByEmailAsync(model.EmailId);
                var userModel = new MasterMember();
                userModel.UserId = getuser.Id;
                userModel.EmailId = model.EmailId;


                await AddMember(userModel);
            }

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        private async Task<bool> AddMember(MasterMember model)
        {
            try
            {
                await _unitOfWork.Member.Add(model);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return true;
        }





        [Route("profile")]
        [HttpPost]
        public async Task<IActionResult> Profile()
        {
            var id = User.FindFirst(ClaimTypes.PrimarySid)?.Value;
            var currentUserBy = await _userManager.FindByIdAsync(id);
            return Ok(currentUserBy);
        }


        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            return GetRandomString(length, alphanumericCharacters);
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            var result = new char[length];
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                cryptoProvider.GetBytes(bytes);
            }
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }
    }
}
