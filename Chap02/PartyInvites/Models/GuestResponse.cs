using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "PLease Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your phone")]
        public string phone { get; set; }
        [Required(ErrorMessage ="Please specify if you will attend")]
        public bool? WillAttend { get; set; }

    }
}