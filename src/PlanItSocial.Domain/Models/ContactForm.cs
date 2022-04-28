using System;
using System.Collections.Generic;
using System.Text;

namespace PlanItSocial.Domain.Models
{
    public class ContactForm
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
