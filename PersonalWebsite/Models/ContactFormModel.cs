using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalWebsite.Models
{
    public class ContactFormModel
    {
        [Required, StringLength(70), Display(Name = "Your name")]
        public string FromName { get; set; }

        [Required, StringLength(255), Display(Name = "Your Email")]
        public string FromEmail { get; set; }

        [Required, StringLength(15), Display(Name = "Phone Number")]
        public string FromPhone { get; set; }

        [Required, StringLength(510), Display(Name = "Message")]
        public string FromMessage { get; set; } 
    }
}