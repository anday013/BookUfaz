using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUfazTest.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Unistra Card ID")]
        public string UnistraCardID { get; set; }
        [Required]
        [Display(Name = "Name Surname")]
        public string StudentNameSurname { get; set; }
        [Required]
        [Display(Name = "Course(1-4)")]
        public int YearID { get; set; }
        [Required]
        [Display(Name = "Faculty")]
        public int FacultyId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
           ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
