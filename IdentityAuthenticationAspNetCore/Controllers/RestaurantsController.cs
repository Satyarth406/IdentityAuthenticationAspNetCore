using IdentityAuthenticationAspNetCore.Models;
using IdentityAuthenticationAspNetCore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IdentityAuthenticationAspNetCore.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IHtmlHelper _htmlHelper;

        public RestaurantsController(IRestaurantRepository restaurantRepository, IHtmlHelper htmlHelper)
        {
            _restaurantRepository = restaurantRepository;
            _htmlHelper = htmlHelper;
        }
       
        public IActionResult Index()
        {
            var allRestaurants = _restaurantRepository.AllRestaurants();
            return View(allRestaurants);
        }

        public IActionResult Create()
        {
            ViewBag.Cuisines = _htmlHelper.GetEnumSelectList(typeof(CuisineType));
            return View(new Restaurant());
        }

        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            ViewBag.Cuisines = _htmlHelper.GetEnumSelectList(typeof(CuisineType));
            _restaurantRepository.CreateRestaurant(restaurant);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Cuisines = _htmlHelper.GetEnumSelectList(typeof(CuisineType));
            var restaurant = _restaurantRepository.GetRestaurantById(id);
            return View(restaurant);
        }
    }
}
