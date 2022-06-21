using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class SameProductDiscountDecorator : IDiscountDecorator
    {
        public DiscountType DiscountType => DiscountType.SameProduct;

        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            DateTime now = DateTime.Now;

            if (discount.DateFrom < now && discount.DateTo > now)
            {
                BasketProductLine line = basket.Products
                    .First(line => line.Product.Id == discount.DiscountProducts.First().ProductId);

                if (discount.DiscountQuantity is null)
                {
                    line.DiscountsApplied.Add
                    (
                        new DiscountApplied
                        {
                            DiscountName = discount.Name,
                            DiscountPercentage = discount.DiscountPercentage,
                            DiscountedQuantity = line.Quantity,
                            DiscountId = discount.Id,
                            OriginalUnitPrice = line.Product.Price,
                            ProductId = line.Product.Id,
                        }
                    );
                }
            }
        }

    }
}
