using RestaurantAppCore.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantAppCore.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllRestaurants();

        
    }
}
