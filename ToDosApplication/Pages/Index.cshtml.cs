/*Author A00246003*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDosApplication.Services;
using ToDosApplication.Models;
using System.Linq;

namespace ToDosApplication.Pages
{
    public class IndexModel : PageModel
    {
        
        private ToDoService _service;

        //Bind Form with Model Class
        [BindProperty]
        public ToDo ToDo { get; set; }
       
        //List to render list of todo
        public List<ToDo> ToDoList = new List<ToDo>();
        public IndexModel(ToDoService service)
        {
            _service = service;
            
        }

        /*
         @method: On page Load render the list from service
            if the action contains then call that method
         */
        public void OnGetAsync(int id,string action)
        {
            ToDoList = _service.GetToDosList();
            if (action == "Edit")
            {
                Edit(id);
            }
            if (action == "Complete")
            {
                Complete(id);
            }
            if (action == "Delete")
            {
                Delete(id);
            }


        }
        /*
         @method: On Submit for 
            if edit then remove from the list and add new one
            else create new object assign values and add to list
         */
        public RedirectToPageResult OnPost()
        {
            if(_service.IdVal != 0)
            {
                var toDoVal = _service.GetToDosList().FirstOrDefault(x => x.ID == _service.IdVal);
                _service.GetToDosList().Remove(toDoVal);
            }       
            ToDo ToDoUpadeted = new ToDo();
            ToDoUpadeted.Description = ToDo.Description;
            ToDoUpadeted.ID = _service.GetToDosList().Count + 1;
            ToDoUpadeted.AddDate = DateTime.Now;
            ToDoUpadeted.IsCompleted = false;
            ToDoList = _service.Add(ToDoUpadeted);
            return RedirectToPage();

        }

        /*
         @method: Delete item from list 
           
         */
        public RedirectToPageResult Delete(int id)
        {
            var toDoVal = _service.GetToDosList().FirstOrDefault(x => x.ID == id);
            _service.GetToDosList().Remove(toDoVal);
            return RedirectToPage();
        }

        /*
         @method: Change lable to completed on click complete button 
           
         */
        public RedirectToPageResult Complete(int id)
        {
            var toDoVal = _service.GetToDosList().FirstOrDefault(x => x.ID == id);
            if (toDoVal != null) toDoVal.IsCompleted = true;
            return RedirectToPage();
        }
        /*
         @method: get the item from list and bind the global bind object
           
         */
        public RedirectToPageResult Edit(int id)
        {
            _service.IdVal = id;
            var toDoVal = _service.GetToDosList().FirstOrDefault(x => x.ID == id);
            ToDo = toDoVal;
            return RedirectToPage();
        }



    }
}
