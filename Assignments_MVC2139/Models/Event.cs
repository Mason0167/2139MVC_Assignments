using System.ComponentModel.DataAnnotations;

namespace Assignments_MVC2139.Models;

public class Event
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title {get; set;}
    [Required]
    public string Category {get; set;}
    [DataType(DataType.Date)]
    public DateTime Date {get; set;}
    [Range(0, 1000)]
    public decimal TicketPrice { get; set; }
    [Range(0, 500)]
    public int AvailableTickets { get; set; }
}