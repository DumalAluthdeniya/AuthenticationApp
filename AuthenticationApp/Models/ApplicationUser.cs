using EntityFrameworkCore.EncryptColumn.Attribute;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [EncryptColumn]
        public string? Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateTime DoB { get; set; }
    }
}
