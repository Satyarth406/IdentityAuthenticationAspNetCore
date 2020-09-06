using System.Collections.Generic;
using IdentityAuthenticationAspNetCore.Models;

namespace IdentityAuthenticationAspNetCore.Repository
{
    public interface IRestaurantRepository
    {
        List<Restaurant> AllRestaurants();
        Restaurant GetRestaurantById(int id);
        Restaurant UpdateRestaurant(Restaurant updatedRestaurant);
        Restaurant CreateRestaurant(Restaurant newRestaurant);
        void DeleteRestaurant(int id);
    }
}
