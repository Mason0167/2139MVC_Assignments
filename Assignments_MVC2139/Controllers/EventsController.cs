using Microsoft.AspNetCore.Mvc;
using Assignments_MVC2139.Models;

namespace Assignments_MVC2139.Controllers;

//DataBase
// private readonly ApplicationDbContext _context; 
// public ProjectTaskController(ApplicationDbContext context) : base() 
// { 
//     _context = context; 
// } 

public class EventsController :Controller
{
    public IActionResult Index()
    {
        //fake data
        var events = new List<Event>
        {
            new Event { Id = 1, Title = "Music Concert", Category = "Concert", Date = DateTime.Parse("2025-11-01"), TicketPrice = 50, AvailableTickets = 100 },
            new Event { Id = 2, Title = "Tech Conference", Category = "Conference", Date = DateTime.Parse("2025-11-10"), TicketPrice = 0, AvailableTickets = 50 },
            new Event { Id = 3, Title = "Art Workshop", Category = "Workshop", Date = DateTime.Parse("2025-12-01"), TicketPrice = 20, AvailableTickets = 200 },
            new Event { Id = 4, Title ="Health Webinar", Category ="Webinar", Date = DateTime.Parse("2025-12-10"), TicketPrice = 10, AvailableTickets = 0}
        };
        return View(events);
    }
    // GET: /Events/Details/1
    public IActionResult Details(int id)
    {
        var events = new List<Event> { /* fake Data */ };
        var ev = events.FirstOrDefault(e => e.Id == id);
        if (ev == null) return NotFound();

        return View(ev);
    }
}