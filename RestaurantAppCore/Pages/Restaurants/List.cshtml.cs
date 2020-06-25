using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RestaurantAppCore.Core;
using RestaurantAppCore.Data;

namespace RestaurantAppCore.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _configuration;

        private readonly IRestaurantData _restaurantData;

        public ListModel(IConfiguration configuration, IRestaurantData restaurantData)
        {
            _configuration = configuration;
            _restaurantData = restaurantData;
        }

        public string Message { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }

        public void OnGet(string searchTerm)
        {
            Message = _configuration["Mess"];
            //Restaurants = _restaurantData.GetAllRestaurants();
            Restaurants = _restaurantData.GetRestaurantByName(searchTerm);
        }
    }
}
