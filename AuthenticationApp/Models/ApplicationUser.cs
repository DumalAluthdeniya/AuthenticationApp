using EntityFrameworkCore.EncryptColumn.Attribute;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public string? Nric { get; set; }     
        public string? ResumePath { get; set; }
        [Required]
        public string? WhoAmI { get; set; }
    }
}
