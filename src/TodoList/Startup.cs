using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace TodoList
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

        }


        public void Configure(IApplicationBuilder app)
        {
            // Add static files to the request pipeline.
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
