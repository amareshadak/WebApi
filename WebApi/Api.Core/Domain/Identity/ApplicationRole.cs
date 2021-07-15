using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Api.Core.Domain
{
    public class ApplicationRole : IdentityRole<long>
    {
        [StringLength(200)]
        public string Description { get; set; }
    }
}
