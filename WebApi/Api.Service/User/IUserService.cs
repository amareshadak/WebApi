using Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service
{
    public interface IUserService : IRepository<ApplicationUser>
    {
        // Task<IEnumerable<ApplicationUser>> GetAllUser();
    }

}
