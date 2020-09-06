using IdentityAuthenticationAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAuthenticationAspNetCore.DatabaseContext
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) :
            base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
