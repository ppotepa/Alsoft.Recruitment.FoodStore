using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Decorator
{
    public interface IDiscountDecorator
    {
        void Decorate(CalculationBasket basket, Entities.Discount discount);
        DiscountType DiscountType { get; }
    }
}