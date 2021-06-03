using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FriendsApp.Areas.Identity.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
    }
}
