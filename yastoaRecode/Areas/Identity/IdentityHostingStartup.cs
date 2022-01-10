using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using yastoaRecode.Areas.Identity.Data;
using yastoaRecode.Data;

[assembly: HostingStartup(typeof(yastoaRecode.Areas.Identity.IdentityHostingStartup))]
namespace yastoaRecode.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<YastoaRecodeDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("yastoaRecodeDbContextConnection")));

                services.AddDefaultIdentity<AplicationUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<YastoaRecodeDbContext>();
            });
        }
    }
}