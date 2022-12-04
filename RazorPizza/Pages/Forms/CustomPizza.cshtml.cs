using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Model;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult  OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            PizzaPrice += Pizza.Sauce ? 1 : 0;
            PizzaPrice += Pizza.Cheese ? 1 : 0;
            PizzaPrice += Pizza.Peperoni ? 1 : 0;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.Name, PizzaPrice });
        }
    }
}
