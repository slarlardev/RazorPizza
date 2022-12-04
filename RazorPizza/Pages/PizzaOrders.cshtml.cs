using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Model;

namespace RazorPizza.Pages
{
    public class PizzaOrdersModel : PageModel
    {
        private readonly AppDbContext _context;

        public List<PizzaOrder> PizzaOrders { get; set; }

        public PizzaOrdersModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
