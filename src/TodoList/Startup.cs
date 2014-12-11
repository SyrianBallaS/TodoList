using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using TodoList.Models;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.ConfigurationModel;

namespace TodoList
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Setup configuration sources.
            Configuration = new Configuration()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();

        }

        public void ConfigureServices(IServiceCollection services)
        {

            // Add EF services to the services container.
            services.AddEntityFramework(Configuration)
                .AddSqlServer()
                .AddDbContext<TodoDbContext>();

            // Add MVC services to the services container.
            services.AddMvc();

            services.AddScoped<ITodoRepository, TodoRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Add static files to the request pipeline.
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
