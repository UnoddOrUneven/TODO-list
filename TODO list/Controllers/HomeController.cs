using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TODO_list.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TODO_list.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TodoContext _context;

        // Inject dependencies 
        public HomeController(ILogger<HomeController> logger, TodoContext context)
        {
            _logger = logger;
            _context = context;
            
        }
        // Acrtion method, runs when you visit /Home/Index (or just /) 
        public async Task<IActionResult> Index()
        {
            // asynchronically get all the todo items from the database 
            var todos = await _context.TodoItems.ToListAsync();
            // Pass the list into todo 
            return View(todos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Here I save new todo to the database
        [HttpPost]
        public async Task<IActionResult> AddToDo(TodoItem todo)
        {
            if (!ModelState.IsValid)
            {
                return View(todo);
            }
            _context.TodoItems.Add(todo);
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> ToggleComplete(int Id, bool IsDone)
        {

            var todo = await _context.TodoItems.FindAsync(Id);
            if (todo != null)
            {
                todo.IsDone = !todo.IsDone;
                await _context.SaveChangesAsync();
            }
            
            return RedirectToAction("Index");

        }



        public async Task<IActionResult> RemoveTask(int Id)
        {
            Console.WriteLine("RemoveTask is triggered");
            var todo = await _context.TodoItems.FindAsync(Id);

            _context.TodoItems.Remove(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
