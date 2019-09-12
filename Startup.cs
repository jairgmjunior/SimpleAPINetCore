using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIS.Data;
using APIS.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace apis
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<StoreDataContext, StoreDataContext>();
            services.AddTransient<ProductRepository, ProductRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();
        }
    }
}
