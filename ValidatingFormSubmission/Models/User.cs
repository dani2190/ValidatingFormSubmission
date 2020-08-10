using System.ComponentModel.DataAnnotations;
namespace ValidatingFormSubmission.Models
{
    public class User
    {
        [Display(Name="First Name")]
        [MinLength(4, ErrorMessage="First Name must be atleast 4 characters")]
        [Required]
        public string FirstName{get; set;}
        [Display(Name="Last Name")]
        [MinLength(4, ErrorMessage="Last Name must be atleast 4 characters")]
        [Required]
        public string LastName{get; set;}
        [Display(Name="Age")]
        [Range(0, 100, ErrorMessage = "Please enter valid age")]
        [Required]
        public string Email {get; set;}
        [Display(Name="Email")]
        [EmailAddress]
        [Required]
        public string Age {get; set;}
        [Display(Name="Password")]
        [MinLength(8, ErrorMessage="Password must be atleast 8 characters")]
        [Required]
        public string Password {get; set;}
    }
}