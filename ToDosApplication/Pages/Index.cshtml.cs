using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using ToDosApplication.Models;

namespace ToDosApplication.Pages
{
    public class IndexModel : PageModel
    {
       
        [BindProperty]
        public IList<ToDo> toDoList { get; set; }

        public void OnGet()
        {
            toDoList = new List<ToDo> {
                new ToDo { ID = 1, Description = "1", AddDate = DateTime.Now, IsCompleted = true},
                new ToDo { ID = 2, Description = "2", AddDate = DateTime.Now, IsCompleted = true},
                new ToDo { ID = 3, Description = "3", AddDate = DateTime.Now, IsCompleted = false}
                 
            };
        }
    }
}
