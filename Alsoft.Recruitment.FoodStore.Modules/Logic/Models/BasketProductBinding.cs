using Alsoft.Recruitment.FoodStore.Entities;
using System;
using System.Collections.Generic;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    public class BasketProductLine
    {
        public BasketProductLine(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            DiscountsApplied = new List<DiscountApplied>();
        }

        public BasketProductLine()
        {
            DiscountsApplied = new List<DiscountApplied>();
        }

        public List<DiscountApplied> DiscountsApplied { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public override bool Equals(object obj)
        {
            return obj is BasketProductLine other &&
                   EqualityComparer<Product>.Default.Equals(this.Product, other.Product) &&
                   this.Quantity == other.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Product, this.Quantity);
        }
    }
}
