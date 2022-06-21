using System;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    public class DiscountApplied
    {
        public string DiscountName { get; set; }
        public double DiscountPercentage { get; set; }
        public int DiscountedQuantity { get; set; }
        public Guid DiscountId { get; set; }
        public Guid ProductId { get; set; }
        public decimal OriginalUnitPrice { get; set; }
        public decimal DiscountedUnitPrice => OriginalUnitPrice * ((decimal)(100 - DiscountPercentage) / 100);
        public decimal Discount => (OriginalUnitPrice * DiscountedQuantity) - (DiscountedQuantity * DiscountedUnitPrice);

        public override string ToString()
        {
            return $"{DiscountName} x{DiscountedQuantity}";
        }
    }
}