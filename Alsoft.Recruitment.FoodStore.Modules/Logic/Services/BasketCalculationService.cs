using Alsoft.Recruitment.FoodStore.DAL;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Services
{
    public class BasketCalculationService
    {
        private readonly AlsoftFoodStoreContext _context;
        private readonly List<IDiscountDecorator> _decorators;

        public BasketCalculationService(
            AlsoftFoodStoreContext context,
            IEnumerable<IDiscountDecorator> decorators
            )
        {
            this._context = context;
            this._decorators = decorators.ToList();
        }

        internal BasketCalculationResult CalculateBasket(BasketCalculationDetails basketCalculationDetails)
        {
            List<BasketProductLine> productBindings = basketCalculationDetails
                .BasketCalculationItems
                .Select(item => new BasketProductLine
                {
                    Product = _context.Product.Single(p => p.Id.Equals(item.Id)),
                    Quantity = item.Quantity
                })
                .ToList();

            List<Entities.Discount> appliableDiscounts = _context.Discount
                .Include(discount => discount.DiscountType)
                .Include(discount => discount.DiscountProducts)
                .Where(discount => discount.DiscountProducts.Select(discountProduct => discountProduct.ProductId)
                    .All(productIds => productBindings.Select(binding => binding.Product.Id)
                    .Any(bindingId => productIds == bindingId)))
                .ToList();

            CalculationBasket basket = new CalculationBasket
            {
                Products = productBindings,
            };

            appliableDiscounts.ForEach(discount =>
            {
                _decorators.ForEach(decorator =>
                {
                    if (decorator.DiscountType == discount.DiscountType.EnumerationId)
                    {
                        decorator.Decorate(basket, discount);
                    }
                });
            });

            return default;
        }
    }
}
