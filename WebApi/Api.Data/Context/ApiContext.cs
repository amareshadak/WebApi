using Api.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class ApiContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<MasterMember> MasterMember { get; set; }
    }
}
