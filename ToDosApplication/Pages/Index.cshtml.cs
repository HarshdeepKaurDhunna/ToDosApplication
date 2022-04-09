using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using ToDosApplication.Models;

namespace ToDosApplication.Pages
{
    public class IndexModel : PageModel
    {
       
        [BindProperty]
        public List<ToDo> toDoList { get; set; }
        public IndexModel()
        {
            toDoList = new List<ToDo> {
                new ToDo { ID = 1, Description = "1", AddDate = DateTime.Now, IsCompleted = true},
                new ToDo { ID = 2, Description = "2", AddDate = DateTime.Now, IsCompleted = true},
                new ToDo { ID = 3, Description = "3", AddDate = DateTime.Now, IsCompleted = false}

            };
        }
        public async Task OnGetAsync()
        {
            toDoList = toDoList;
        }
        public void Add(ToDo ToDo)
        {
            ToDo ToDoUpdate = new ToDo();
            ToDoUpdate.AddDate = ToDo.AddDate;
            ToDoUpdate.Description = ToDo.Description;
            ToDoUpdate.IsCompleted = ToDo.IsCompleted;
            ToDoUpdate.ID = toDoList.Count + 1;
            toDoList.Add(ToDo);
            Debug.WriteLine(toDoList.Count + "=============");
        }

        public void Delete(ToDo ToDo)
        {
            toDoList.Remove(ToDo);
        }
    }
}
