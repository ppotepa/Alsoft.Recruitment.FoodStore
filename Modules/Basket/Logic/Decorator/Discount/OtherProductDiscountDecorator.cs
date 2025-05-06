using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using System;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class OtherProductDiscountDecorator : IDiscountDecorator
    {
        public DiscountType DiscountType => DiscountType.OtherProduct;
        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            DateTime now = DateTime.Now;

            if (discount.DateFrom >= now || discount.DateTo <= now || discount.DiscountQuantity is null)
                return;

            var firstProduct = basket.Products.First(line => line.Product.Id == discount.DiscountProducts.First().ProductId);
            int maxDiscountedQuantity = firstProduct.Quantity / (int)discount.DiscountQuantity;

            BasketProductLine line = basket.Products.FirstOrDefault(line => line.Product.Id == discount.TargetProductId);

            if (line is not null)
            {
                line.DiscountsApplied.Add(new DiscountApplied
                {
                    DiscountedQuantity = Math.Min(maxDiscountedQuantity, line.Quantity),
                    DiscountName = discount.Name,
                    DiscountPercentage = discount.DiscountPercentage,
                    DiscountId = discount.Id,
                    OriginalUnitPrice = line.Product.Price,
                    ProductId = line.Product.Id,
                });
            }
        }
    }
}
