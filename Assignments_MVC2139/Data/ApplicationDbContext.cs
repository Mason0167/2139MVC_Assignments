using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using Assignments_MVC2139.Models;

namespace Assignments_MVC2139.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Event> Events { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
}