using Microsoft.Extensions.DependencyInjection;

namespace Alsoft.Recruitment.FoodStore.Modules.Product.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddProductsModule(this IServiceCollection @this)
        {
            return @this;
        }
    }
}
