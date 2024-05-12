using Autofac.Extensions.DependencyInjection;
using Autofac;
using Library_DataAccess.DependencyResolvers.Autofac;
using Library_DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Library_DataAccess.Context.IdentityContext;
using Library_Core.Entities.UserEntities.Concrete;
using Microsoft.AspNetCore.Identity;
using FluentValidation.AspNetCore;
using FluentValidation;
using Library_DataAccess.FluentValidators.AccountValidators;
using Library_DataAccess.FluentValidators.BookValidators;
using Library_DataAccess.FluentValidators.GenreValidators;
using Library_DataAccess.FluentValidators.AuthorValidators;
using Library_DataAccess.FluentValidators.PublisherValidators;
using Library_DataAccess.FluentValidators.CommentValidators;
using Library_DataAccess.FluentValidators.RoleValidators;

namespace Library_WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddValidatorsFromAssemblyContaining<RegisterValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<LoginValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<EditUserValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<ChangePasswordValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AddBookValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdateBookValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AddGenreValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdateGenreValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AddAuthorValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdateAuthorValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AddPublisherValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdatePublisherValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<AddCommentValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<CreateRoleValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<UpdateRoleValidator>();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddFluentValidationClientsideAdapters();


            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                       .ConfigureContainer<ContainerBuilder>(builder =>
                       {
                           builder.RegisterModule(new AutofacBusinessModule());
                       });

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            var connectionIdentityString = builder.Configuration.GetConnectionString("DefaultIdentityConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddDbContext<AppIdentityDbContext>(options =>
            {
                options.UseSqlServer(connectionIdentityString);
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
               name: "areas",
               pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
