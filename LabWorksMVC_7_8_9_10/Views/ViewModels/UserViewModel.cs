using System.ComponentModel.DataAnnotations;

namespace LabWorksMVC_7_8_9_10.Views.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }
    }
}

