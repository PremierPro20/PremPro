using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace PremierPro.Data
{
    public class ApplicationUser : IdentityUser
    {
        public override string Id { get; set; }

        [DisplayName("Name")]
        public string? FullName { get; set; }
        [DisplayName("Email")]
        public string? EmailAddress { get; set; }
        [DisplayName("Username")]
        public string? PremierProUsername { get; set; }
        [DisplayName("Password")]
        public string? Password { get; set; }

        public ApplicationUser()
        {

        }

    }
}