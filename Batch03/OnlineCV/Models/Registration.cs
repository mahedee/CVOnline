using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        public string ConfirmPassword { get; set; }
    }
}