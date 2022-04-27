using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanItSocial.Models
{
    // Location class 
    public class Location
    {
        // Variables
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Relational data
        public virtual ICollection<Event> Events { get; set; }
    }
}
