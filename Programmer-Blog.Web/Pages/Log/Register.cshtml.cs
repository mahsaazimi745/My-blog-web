using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Programming_Blog.CoreLayer.DTOs.User;
using Programming_Blog.CoreLayer.Services.Users;
using Programming_Blog.CoreLayer.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Programmer_Blog.Web.Pages.Log
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;
        #region Proprties
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Password")]

        public string Password { get; set; }
        #endregion
        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var result = _userService.RegisterUser(new UserRegisterDto()
            {
                UserName = UserName,
                FullName = FullName,
                Password = Password


            });
            if (result.Status == OperationResultStatus.Error)
            {
                ModelState.AddModelError("UserName", result.Message);
                return Page();
            }
            else
            return RedirectToPage("Login");
        }
    }
}
