using Restaurant.Model;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.DataAccess
{
    public class GetRestaurants :IGetRestaurants
    {
        List<RestaurantDetails> Restaurants;
        public GetRestaurants() {
            Restaurants = new List<RestaurantDetails>()
            {
               new RestaurantDetails(){ID=1,RestaurantName = "Taste Of India", Cuisine=CuisineType.Indian },
               new RestaurantDetails(){ID=2,RestaurantName = "Wang Chi", Cuisine=CuisineType.Chineese  },
               new RestaurantDetails(){ ID=3, RestaurantName="Le Meridian", Cuisine=CuisineType.French},
               new RestaurantDetails(){ ID=4, RestaurantName="La Milano", Cuisine=CuisineType.Italian}
            };
        }
        public IEnumerable<RestaurantDetails> GetAll()
        {
            return from r in Restaurants orderby r.RestaurantName
                   select r;
        }

        
    }
}
