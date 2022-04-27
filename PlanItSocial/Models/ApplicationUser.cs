using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanItSocial.Models
{
    // ApplicationUser class inheriting IdentityUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
