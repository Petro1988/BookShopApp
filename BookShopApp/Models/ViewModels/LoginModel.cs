using System.ComponentModel.DataAnnotations;

namespace BookShopApp.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
