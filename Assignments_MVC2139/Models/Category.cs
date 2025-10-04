using System.ComponentModel.DataAnnotations;

namespace Assignments_MVC2139.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}