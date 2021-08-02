using Microsoft.AspNetCore.Mvc.RazorPages;
using Restaurant.DataAccess;

namespace Restaurant.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly IGetRestaurants restaurants;

        public void OnGet()
        {
        }
    }
}
