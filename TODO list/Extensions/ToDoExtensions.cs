namespace TODO_list.Extensions
{
    public static class ToDoExtensions
    {
        public static string GetStatus(this Models.TodoItem todo)
        {
            return todo.IsDone ? "Done ✅" : "In process";
        }
    }
}
