using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Data
{
    public class ApplicationUser : IdentityUser<long>
    {
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
    }

    public class ApplicationRole : IdentityRole<long>
    {
        [StringLength(200)]
        public string Description { get; set; }
    }
}
