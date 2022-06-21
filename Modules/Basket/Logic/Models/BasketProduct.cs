using System;
using System.Collections.Generic;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    public class BasketProduct
    {
        public BasketProduct()
        {
            DiscountsApplied = new List<DiscountApplied>();
        }

        public List<DiscountApplied> DiscountsApplied { get; set; }
        public Guid Id { get; set; }
        public decimal ItemsPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}