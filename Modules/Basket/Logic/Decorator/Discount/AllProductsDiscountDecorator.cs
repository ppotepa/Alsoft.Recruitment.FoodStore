using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class AllProductsDiscountDecorator : IDiscountDecorator
    {
        public DiscountType DiscountType => DiscountType.AllProducts;
        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            DateTime now = DateTime.Now;

            if (discount.DateFrom < now && discount.DateTo > now)
            {
                List<BasketProductLine> applicableProducts = basket
                .Products.Where(line =>
                {
                    return  discount.DiscountProducts
                            .Select(x => x.ProductId)
                            .Contains(line.Product.Id) && line.DiscountsApplied.Count != line.Quantity;
                })
                .ToList();

                if (applicableProducts.Count == discount.DiscountProducts.Count)
                {
                    if (applicableProducts.All(line => line.Quantity == applicableProducts.First().Quantity))
                    {
                        var quantity = applicableProducts.First().Quantity;
                        applicableProducts.ForEach(line =>
                        {
                            line.DiscountsApplied.Add
                            (
                                new DiscountApplied
                                {
                                    DiscountedQuantity = quantity,
                                    DiscountName = discount.Name,
                                    DiscountPercentage = discount.DiscountPercentage,
                                    DiscountId = discount.Id    ,
                                    OriginalUnitPrice = line.Product.Price,
                                    ProductId = line.Product.Id,
                                }
                            );

                            line.SameProductDiscountId = discount.Id;
                        });
                    }
                    else
                    {
                        int toBeDiscounted = applicableProducts.Min(x => x.Quantity);
                        
                        applicableProducts.ForEach(line =>
                        {
                            line.DiscountsApplied.Add
                            (
                                new DiscountApplied
                                {
                                    DiscountedQuantity = toBeDiscounted,
                                    DiscountName = discount.Name,
                                    DiscountPercentage = discount.DiscountPercentage,
                                    DiscountId = discount.Id,
                                    OriginalUnitPrice = line.Product.Price,
                                    ProductId = line.Product.Id,
                                }
                            );

                            line.SameProductDiscountId = discount.Id;
                        });
                    }
                }
            }
        }
    }
}
