using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI_Bravo.ExternalServices;
using WebApiBravo.Models;

namespace WEBAPI_Bravo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
     
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<BravoContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            



            services.AddControllers();
            services.AddHttpClient<ExternalApiService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Serasi CMS Api", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllers();

               
                // Schedule the job
              
            });

            // Enable Swagger
            app.UseSwagger();


            // Enable Swagger UI
            app.UseSwaggerUI(c =>
            {
                //c.SwaggerEndpoint("/Serasi/swagger/v1/swagger.json", "Syntera API V1");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Syntera API V1");
            });
        }
    }


}
