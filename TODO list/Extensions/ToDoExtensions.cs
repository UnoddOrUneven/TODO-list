﻿using System.Drawing;
using System.Text;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace TODO_list.Extensions
{
    
    public static class ToDoExtensions
    {
        


        public static string GetStatus(this Models.TodoItem todo)
        {
            return todo.IsDone ? "Done" : "In process";
        }

        public static string GetStatusSettings(this Models.Settings settings)
        {
            return settings.IsOn ? "Enabled" : "Disabled"; 
        }

    }
}
