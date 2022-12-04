using Microsoft.EntityFrameworkCore;
using RazorPizza.Model;

namespace RazorPizza.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
