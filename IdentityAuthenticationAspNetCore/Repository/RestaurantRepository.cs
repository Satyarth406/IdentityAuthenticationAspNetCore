using IdentityAuthenticationAspNetCore.DatabaseContext;
using IdentityAuthenticationAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAuthenticationAspNetCore.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantDbContext _restaurantDbContext;

        public RestaurantRepository(RestaurantDbContext restaurantDbContext)
        {
            _restaurantDbContext = restaurantDbContext;
        }
        public List<Restaurant> AllRestaurants()
        {
            return _restaurantDbContext.Restaurants.ToList();
        }

        public Restaurant CreateRestaurant(Restaurant newRestaurant)
        {
            _restaurantDbContext.Restaurants.Add(newRestaurant);
            _restaurantDbContext.SaveChanges();
            return newRestaurant;
        }

        public void DeleteRestaurant(int id)
        {
            _restaurantDbContext.Restaurants.Remove(_restaurantDbContext.Restaurants.Find(id));
            _restaurantDbContext.SaveChanges();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _restaurantDbContext.Restaurants.FirstOrDefault(t => t.Id == id);
        }

        public Restaurant UpdateRestaurant(Restaurant updatedRestaurant)
        {
            _restaurantDbContext.Restaurants.Update(updatedRestaurant);
            _restaurantDbContext.SaveChanges();
            return updatedRestaurant;
        }
    }
}
