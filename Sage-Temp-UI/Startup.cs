using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Sage_Temp_UI.Services;
using Sage_Temp_UI.TcrIdentity;
using System;
using Microsoft.AspNet.Http;
using Sage_Temp_UI.Utility;
using Tcr.Sage.Dal.I;
using Tcr.Sage.Dal.SqlServer;
using Tcr.Sage.Dal.SqlServer.Repository;

namespace Sage_Temp_UI {
   public class Startup {
      public Startup(IHostingEnvironment env) {
         // Set up configuration sources.
         var builder = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

         if (env.IsDevelopment()) {
            // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
            builder.AddUserSecrets();
         }

         builder.AddEnvironmentVariables();
         Configuration = builder.Build();
      }

      public IConfigurationRoot Configuration { get; set; }

      // This method gets called by the runtime. Use this method to add services to the container.
      public void ConfigureServices(IServiceCollection services) {

         // Add framework services.
         services.AddEntityFramework()
             .AddSqlServer()
             .AddDbContext<TcrIdentityDbContext>(options =>
                 options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]))
             .AddDbContext<SageContext>(options =>
                 options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));

         services.AddIdentity<TcrUser, TcrRole>(o => {
            // configure identity options
            o.Password.RequireDigit = false;
            o.Password.RequireLowercase = false;
            o.Password.RequireUppercase = false;
            o.Password.RequireNonLetterOrDigit = false;
            o.Password.RequiredLength = 5;
            o.User.RequireUniqueEmail = true;
            o.SecurityStampValidationInterval = TimeSpan.FromDays(14);
         })
             .AddEntityFrameworkStores<TcrIdentityDbContext, int>()
             .AddDefaultTokenProviders();

         services.AddMvc().AddJsonOptions(options =>
            options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

         // Add application services.
         services.AddTransient<IEmailSender, AuthMessageSender>();
         services.AddTransient<ISmsSender, AuthMessageSender>();
         services.AddScoped<ICompanyRepository, CompanyRepository>();
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory) {
         loggerFactory.AddConsole(Configuration.GetSection("Logging"));
         loggerFactory.AddDebug();

         if (env.IsDevelopment()) {
            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
         }
         else {
            app.UseExceptionHandler("/Home/Error");

            // For more details on creating database during deployment see http://go.microsoft.com/fwlink/?LinkID=615859
            try {
               using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                   .CreateScope()) {
                  serviceScope.ServiceProvider.GetService<TcrIdentityDbContext>()
                       .Database.Migrate();
               }
            }
            catch { }
         }

         app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

         app.UseStaticFiles();

         app.UseIdentity();

         // To configure external authentication please see http://go.microsoft.com/fwlink/?LinkID=532715

         app.UseMvc(routes => {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
         });

         var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
         UrlExtensions.Configure(httpContextAccessor);
      }

      // Entry point for the application.
      public static void Main(string[] args) => WebApplication.Run<Startup>(args);
   }
}
