using System.Collections.Generic;
using ProjectNC01.Models;

namespace ProjectNC01.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "작성이 필요한 필드입니다.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "작성이 필요한 필드입니다.")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "작성이 필요한 필드입니다.")]
        public string Gender { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="비밀번호가 서로 일치하지 않습니다.")]
        public string ConfirmPassword { get; set; }
    }
}
