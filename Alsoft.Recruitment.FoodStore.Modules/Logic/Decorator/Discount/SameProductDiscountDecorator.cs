using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class SameProductDiscountDecorator : IDiscountDecorator
    {
        public DiscountType DiscountType => DiscountType.SameProduct;

        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            BasketProductLine targetProduct = basket.Products.First(line => line.Product.Id == discount.DiscountProducts.First().ProductId);
            targetProduct.DiscountsApplied.Add
            (
                new DiscountApplied 
                {
                    DiscountName = discount.Name,
                    DiscountPercentage = discount.DiscountPercentage 
                }
            );
        }
     
    }
}
    