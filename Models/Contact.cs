using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordBank.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "this field is required")]
        [MaxLength(50, ErrorMessage = "this field only supports 50 caracters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [MaxLength(70,ErrorMessage = "this field only supports 70 caracters")]
        [EmailAddress(ErrorMessage = "this field is invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [MaxLength(70,ErrorMessage = "this field only supports 70 caracters")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [MaxLength(2000, ErrorMessage = "this field only supports 2000 caracters")]
        public string Message { get; set; }
    }
}
