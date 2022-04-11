/*
 * Service class to manage the todo model;
 */




using System;
using System.Collections.Generic;
using System.Diagnostics;
using ToDosApplication.Models;

namespace ToDosApplication.Services
{
    public class ToDoService
    {
        List<ToDo> ToDoList = new();
       
        public int IdVal = 0;
        public ToDoService()
        {
            ToDoList = ToDoList;
        }

        //Incomplete todos
        public List<ToDo> GetToDosList()
        {
            return ToDoList;
        }

        //Add todo to the list
        public List<ToDo> Add(ToDo ToDo)
        {
            ToDoList.Add(ToDo);
            return ToDoList;
        }


      
        
    }
}
