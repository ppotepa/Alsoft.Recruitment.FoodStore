using Alsoft.Recruitment.FoodStore.UI.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace Alsoft.Recruitment.FoodStore.UI
{
    public partial class App
    {
        public App()
        {
            Services = ConfigureServices();
        }

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        private static IServiceProvider ConfigureServices()
        {
            ServiceCollection? services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            services.AddSingleton<BasketAppViewModel>();
            return services.BuildServiceProvider();
        }

        public BasketAppViewModel ViewModel => Services.GetService<BasketAppViewModel>() 
            ?? throw new InvalidProgramException("View Model returned null");
    }
}
