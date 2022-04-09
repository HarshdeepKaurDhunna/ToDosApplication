
using System;

namespace ToDosApplication.Models
{
    public class ToDo
    {
    
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsCompleted { get; set; }

    }
}