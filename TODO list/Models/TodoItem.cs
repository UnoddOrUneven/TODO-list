using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace TODO_list.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
        

    }

    // Move it out of here!!!
    public class Settings
    {
        public int Id { get; set; }
        public string Title { get; set; } = ("setting"); 
        public bool IsOn { get; set; }
    }
}
