using Microsoft.EntityFrameworkCore;
using RazorPizzaProject.Models;

namespace RazorPizzaProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
