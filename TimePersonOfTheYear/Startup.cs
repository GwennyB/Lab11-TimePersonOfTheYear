using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace TimePersonOfTheYear
{
    public class Startup
    {
        /// <summary>
        /// Loads required dependencies
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        /// <summary>
        /// Configures the runtime environment: serves static files and sets default route
        /// </summary>
        /// <param name="app"> interface to manage requests </param>
        /// <param name="env"> interface to manage web hosting </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
