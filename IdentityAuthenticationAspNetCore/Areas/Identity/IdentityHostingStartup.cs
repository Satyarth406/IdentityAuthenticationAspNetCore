using System;
using IdentityAuthenticationAspNetCore.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityAuthenticationAspNetCore.Areas.Identity.IdentityHostingStartup))]
namespace IdentityAuthenticationAspNetCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityAspNetContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityAspNetContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityAspNetContext>();
            });
        }
    }
}