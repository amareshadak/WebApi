using Api.Data;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service
{
    public class UserService : Repository<ApplicationUser>, IUserService
    {
        public UserService(ApiContext context) : base(context)
        {

        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
           //  throw new NotImplementedException();
        }
    }
}