using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using System;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class AllProductsDiscountDecorator : IDiscountDecorator
    {
        #region Properties

        public DiscountType DiscountType => DiscountType.AllProducts;

        #endregion Properties

        #region Methods

        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            DateTime now = DateTime.Now;

            if (discount.DateFrom >= now || discount.DateTo <= now) return;

            var applicableProducts = basket.Products
                .Where(line => discount.DiscountProducts
                    .Select(x => x.ProductId)
                    .Contains(line.Product.Id) && line.DiscountsApplied.Count != line.Quantity)
                .ToList();

            if (applicableProducts.Count != discount.DiscountProducts.Count) return;

            int toBeDiscounted = applicableProducts.All(line => line.Quantity == applicableProducts.First().Quantity)
                ? applicableProducts.First().Quantity
                : applicableProducts.Min(x => x.Quantity);

            applicableProducts.ForEach(line =>
            {
                line.DiscountsApplied.Add(new DiscountApplied
                {
                    DiscountedQuantity = toBeDiscounted,
                    DiscountName = discount.Name,
                    DiscountPercentage = discount.DiscountPercentage,
                    DiscountId = discount.Id,
                    OriginalUnitPrice = line.Product.Price,
                    ProductId = line.Product.Id,
                });

                line.SameProductDiscountId = discount.Id;
            });
        }

        #endregion Methods
    }
}
