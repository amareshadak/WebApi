using Api.Core.Domain;

namespace Api.Service
{
    public interface IUserService : IRepository<ApplicationUser>
    {
        //Task<IEnumerable<ApplicationUser>> GetAllUser();
    }

}
