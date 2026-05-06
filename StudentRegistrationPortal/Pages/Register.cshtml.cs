using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentRegistrationPortal.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string StudentName { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            Message = $"Hello {StudentName}, Registration Successful!";
        }
    }
}
