using Microsoft.AspNetCore.Mvc;
using Assignments_MVC2139.Models;

namespace Assignments_MVC2139.Controllers;

public class EventsController :Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}