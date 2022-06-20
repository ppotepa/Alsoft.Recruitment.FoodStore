using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class AllProductsDiscountDecorator : IDiscountDecorator
    {
        public DiscountType DiscountType => DiscountType.AllProducts;

        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            throw new System.NotImplementedException();
        }
    }
}
