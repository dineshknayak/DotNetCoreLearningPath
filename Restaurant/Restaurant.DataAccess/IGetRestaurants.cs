using Restaurant.Model;
using System.Collections.Generic;

namespace Restaurant.DataAccess
{
    public interface IGetRestaurants {

        IEnumerable<RestaurantDetails> GetAll();
    }
}
