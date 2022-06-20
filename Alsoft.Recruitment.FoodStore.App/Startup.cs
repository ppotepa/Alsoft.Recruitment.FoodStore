using Alsoft.Recruitment.FoodStore.Abstractions.Interfaces;
using Alsoft.Recruitment.FoodStore.DAL;
using Alsoft.Recruitment.FoodStore.Modules.Basket;
using Alsoft.Recruitment.FoodStore.Modules.Basket.DependencyInjection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            List<Type> allAvailableTypes = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .ToList();

            List<Type> transientTypes = allAvailableTypes.Where(type => type.GetInterfaces().Contains(typeof(ITransientServiceMarker))).ToList();

            services.AddControllers();
            services.AddDbContext<AlsoftFoodStoreContext>(
                options => options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            );
                

            transientTypes.ForEach(type => services.AddTransient(type));

            services.AddMediatR
            (
                typeof(IBasketModuleMarker) 
            );

            services.AddBasketModule();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Alsoft.Recruitment.FoodStore.Api", Version = "v1" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Alsoft.Recruitment.FoodStore.Api v1"));
            }

            app.UseHttpsRedirection();
           
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
