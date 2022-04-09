using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDosApplication.Models;

namespace ToDosApplication.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public ToDo ToDo { get; set; }
        public void OnGet()
        {
        }
    }
}
