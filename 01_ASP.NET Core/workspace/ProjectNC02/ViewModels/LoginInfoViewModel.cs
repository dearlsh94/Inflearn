using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ProjectNC02.ViewModels
{
    public class LoginInfoViewModel
    {
        [Required(ErrorMessage = "Please Input ID")]
        [MinLength(6)]
        [Display(Name="ID")]
        public string UserId { get; set; }
        
        [Required(ErrorMessage = "Please Input Password")]
        [MinLength(6)]
        [Display(Name="Password")]
        public string Password { get; set; }
    }
}