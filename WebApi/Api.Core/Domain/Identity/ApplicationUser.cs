using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Core.Domain
{
    public class ApplicationUser : IdentityUser<long>
    {
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        [StringLength(100)]
        public string UserType { get; set; } // Admin or Company User or Member
        public bool IsDeleted { get; set; } = false;
    }
}
