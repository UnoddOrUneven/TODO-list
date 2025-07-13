using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TODO_list.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TODO_list.Controllers
{
    public class SettingsController: Controller
    {
        private readonly ILogger<SettingsController> _logger;
        private readonly TodoContext _context;


        public SettingsController(ILogger<SettingsController> logger, TodoContext context)
            {
            _logger = logger;
            _context = context;


            }

        [HttpGet]
        public async Task<IActionResult> AddSetting(string title)
        {
            Settings setting = new Settings()
            {
                Title = title,
                IsOn = false
            };

            _context.Settings.Add(setting);

            await _context.SaveChangesAsync();
            return RedirectToAction("Settings");

        }

        public async Task<IActionResult> ToggleOn(int Id, bool IsOn)
        {
            var setting = await _context.Settings.FindAsync(Id);
            if (setting != null)
            {
                setting.IsOn = !setting.IsOn;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Settings");
        }


    }
}
