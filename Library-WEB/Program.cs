using Autofac.Extensions.DependencyInjection;
using Autofac;
using Library_DataAccess.DependencyResolvers.Autofac;
using Library_DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Library_DataAccess.Context.IdentityContext;
using Library_Core.Entities.UserEntities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Library_WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                       .ConfigureContainer<ContainerBuilder>(builder =>
                       {
                           builder.RegisterModule(new AutofacBusinessModule());
                       });

            var connectionString = builder.Configuration.GetConnectionString("PostgresSQLConnection");
            var connectionStringIdentity = builder.Configuration.GetConnectionString("PostgresSQLIdentityConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            builder.Services.AddDbContext<AppIdentityDbContext>(options =>
            {
                options.UseNpgsql(connectionStringIdentity);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
            {
                x.SignIn.RequireConfirmedPhoneNumber = false;
                x.SignIn.RequireConfirmedAccount = false;
                x.SignIn.RequireConfirmedEmail = false;
                x.User.RequireUniqueEmail = true;
                x.Password.RequiredLength = 1;
                x.Password.RequiredUniqueChars = 0;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireLowercase = false;
            })
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
