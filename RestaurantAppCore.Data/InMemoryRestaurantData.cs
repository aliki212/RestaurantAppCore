using RestaurantAppCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantAppCore.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> restaurantsList;

        public InMemoryRestaurantData()
        {
            restaurantsList = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Aglio", Location = "Chalandri", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Escoba", Location = "Kifisia", Cuisine = CuisineType.Mexican},
                new Restaurant {Id = 3, Name = "Mparmbounakia", Location = "N.Erithrea", Cuisine = CuisineType.Greek}
            };
        }


        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return from restaurant in restaurantsList
                   orderby restaurant.Name
                   select restaurant;
        }

        
    }
}
