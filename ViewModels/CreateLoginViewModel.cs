using System.ComponentModel.DataAnnotations;

namespace ApiLogin.ViewModels
{
    public class CreateLoginViewModel
    {
        [Required(ErrorMessage = "Enter User")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Must be 5 to 30 characters")]
        public string User { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
    }
}
