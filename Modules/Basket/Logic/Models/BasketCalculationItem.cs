using System;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    internal class BasketCalculationItem
    {
        public BasketCalculationItem(Guid id, int quantity)
        {
            this.Id = id;
            this.Quantity = quantity;
        }

        public Guid Id { get; }
        public int Quantity { get; }
        public override bool Equals(object obj)
        {
            return obj is BasketCalculationItem other &&
                   this.Id == other.Id &&
                   this.Quantity == other.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Quantity);
        }
    }
}
