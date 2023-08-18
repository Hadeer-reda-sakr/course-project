using System.ComponentModel.DataAnnotations;

namespace Web.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email Or UserName")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
