using System;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    public class BasketProduct
    {
        public DiscountApplied[] DiscountsApplied { get; set; }
        public Guid Id { get; set; }
        public decimal ItemsPrice { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}