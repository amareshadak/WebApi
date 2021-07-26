using Api.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApiContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public virtual DbSet<MasterMember> MasterMember { get; set; }
    }
}
