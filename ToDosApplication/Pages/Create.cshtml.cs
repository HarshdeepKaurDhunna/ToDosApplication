using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDosApplication.Models;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ToDosApplication.Pages { 

public class CreateModel : PageModel
{
    [BindProperty]
    public ToDo ToDo { get; set; }
    public void OnGet()
    {
    }
    public IActionResult OnPost()
    {
        IndexModel IndexModel = new IndexModel();
        ToDo.AddDate = System.DateTime.Now;
        IndexModel.Add(ToDo);
        return RedirectToPage("./Index");
    }
}
    }
