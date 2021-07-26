using Api.Core.Domain;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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