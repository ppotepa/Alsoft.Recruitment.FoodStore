using Alsoft.Recruitment.FoodStore.Abstractions.Interfaces;
using Alsoft.Recruitment.FoodStore.DAL;
using Alsoft.Recruitment.FoodStore.Modules.Basket;
using Alsoft.Recruitment.FoodStore.Modules.Basket.DependencyInjection;
using Alsoft.Recruitment.FoodStore.Modules.Product;
using Alsoft.Recruitment.FoodStore.Modules.Product.DependencyInjection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
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

            services.AddDbContext<AlsoftFoodStoreContext>(options =>
            {
                options.UseInMemoryDatabase(nameof(AlsoftFoodStoreContext));
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
            });

            transientTypes.ForEach(type => services.AddTransient(type));


            services.AddMvc().AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddMediatR
            (
                typeof(IBasketModuleMarker),
                typeof(IProductModuleMarker)
            );

            services.AddBasketModule();
            services.AddProductsModule();

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

            using var scope = app.ApplicationServices.CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<AlsoftFoodStoreContext>();
            context.Database.EnsureCreated();

        }
    }
}
