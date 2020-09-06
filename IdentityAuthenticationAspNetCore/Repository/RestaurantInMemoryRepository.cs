using System.Collections.Generic;
using System.Linq;
using IdentityAuthenticationAspNetCore.Models;

namespace IdentityAuthenticationAspNetCore.Repository
{
    public class RestaurantInMemoryRepository : IRestaurantRepository
    {
        //In-Memory list of data
        public List<Restaurant> RestaurantList = new List<Restaurant>()
        {
            new Restaurant(){ Id=1, Name="Restaurant 1",Country="India", DineIn=true, City="Bangalore", Cuisine=CuisineType.Indian},
            new Restaurant(){ Id=2, Name="Restaurant 2",Country="India", DineIn=false, City="Mumbai", Cuisine=CuisineType.None},
            new Restaurant(){ Id=3, Name="Restaurant 3",Country="India", DineIn=true, City="Delhi", Cuisine=CuisineType.Chinese},
            new Restaurant(){ Id=4, Name="Restaurant 4",Country="India", DineIn=false, City="Kolkata", Cuisine=CuisineType.Mexican}
        };
        public List<Restaurant> AllRestaurants()
        {
            return RestaurantList;
        }

        public Restaurant CreateRestaurant(Restaurant newRestaurant)
        {
            int maxId = RestaurantList.Max(t => t.Id);
            newRestaurant.Id = maxId + 1;
            RestaurantList.Add(newRestaurant);
            return newRestaurant;
        }

        public void DeleteRestaurant(int id)
        {
            var res = RestaurantList.FirstOrDefault(t => t.Id == id);
            RestaurantList.Remove(res);
        }

        public Restaurant GetRestaurantById(int id)
        {
            return RestaurantList.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant UpdateRestaurant(Restaurant updatedRestaurant)
        {
            var restaurant = RestaurantList.FirstOrDefault(res => res.Id == updatedRestaurant.Id);
            restaurant.Name = updatedRestaurant.Name;
            restaurant.City = updatedRestaurant.City;
            restaurant.Country = updatedRestaurant.Country;
            restaurant.Cuisine = updatedRestaurant.Cuisine;
            restaurant.DineIn = updatedRestaurant.DineIn;
            return restaurant;
        }
    }
}
