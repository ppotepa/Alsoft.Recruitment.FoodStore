using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using System;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator.Discount
{
    internal class OtherProductDiscountDecorator : IDiscountDecorator
    {
        public DiscountType DiscountType => DiscountType.OtherProduct;
        public void Decorate(CalculationBasket basket, Entities.Discount discount)
        {
            throw new NotImplementedException();
        }
    }
}
