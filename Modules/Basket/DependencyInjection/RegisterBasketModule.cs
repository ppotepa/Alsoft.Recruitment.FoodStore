using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection @this)
        {
            
            @this.AddTransient<BasketCalculationService>();
            @this.AddTransient<IDiscountDecorator, AllProductsDiscountDecorator>();
            @this.AddTransient<IDiscountDecorator, OtherProductDiscountDecorator>();
            @this.AddTransient<IDiscountDecorator, SameProductDiscountDecorator>();

            return @this;

        }
    }
}
