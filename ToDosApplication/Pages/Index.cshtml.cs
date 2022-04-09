using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDosApplication.Models;

namespace ToDosApplication.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public List<ToDo> toDoList { get; set; } = new List<ToDo>();
        public IndexModel()
        {
           
        }
        public void OnGetAsync()
        {
            
        }

        public void Add(ToDo ToDo)
        {
            ToDo ToDoUpdate = new ToDo();
            ToDoUpdate.AddDate = ToDo.AddDate;
            ToDoUpdate.Description = ToDo.Description;
            ToDoUpdate.IsCompleted = ToDo.IsCompleted;
            ToDoUpdate.ID = toDoList.Count + 1;
            toDoList.Add(ToDo);
            
        }

        public void Delete(ToDo ToDo)
        {
            toDoList.Remove(ToDo);
        }
    }
}
