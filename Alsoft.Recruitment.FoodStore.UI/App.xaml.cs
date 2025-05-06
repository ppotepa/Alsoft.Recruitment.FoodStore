using Alsoft.Recruitment.FoodStore.UI.ViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace Alsoft.Recruitment.FoodStore.UI
{
    public partial class App
    {
        public App()
        {
            var collection = new ServiceCollection();
            ConfigureServices(collection);
            Services = collection.BuildServiceProvider();
        }

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; private set; } = null!;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(provider =>
                new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build());

            services.AddTransient<BasketAppViewModel>();
        }

        public BasketAppViewModel ViewModel => Services.GetService<BasketAppViewModel>()
            ?? throw new InvalidProgramException("View Model returned null");
    }
}
