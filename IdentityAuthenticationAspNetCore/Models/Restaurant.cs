namespace IdentityAuthenticationAspNetCore.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool DineIn { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
