using System.ComponentModel.DataAnnotations;

namespace ProjectNC01.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "작성이 필요한 필드입니다.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "작성이 필요한 필드입니다.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
