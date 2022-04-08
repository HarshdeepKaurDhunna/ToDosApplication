using System;
using System.ComponentModel.DataAnnotations;
namespace ToDosApplication.Models
{
    public class ToDoModel
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime addDate { get; set; }
        public bool IsCompleted { get; set; }
        
    }
}
