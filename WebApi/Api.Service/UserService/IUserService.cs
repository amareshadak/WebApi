using Api.Core.Domain;
using Api.Data;

namespace Api.Service
{
    public interface IUserService : IRepository<ApplicationUser>
    {
        //Task<IEnumerable<ApplicationUser>> GetAllUser();
    }

}
