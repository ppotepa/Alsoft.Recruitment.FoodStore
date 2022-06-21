using Alsoft.Recruitment.FoodStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    public class BasketProductLine
    {
        public BasketProductLine()
        {
            DiscountsApplied = new List<DiscountApplied>();
        }

        public bool AlreadyDiscounted => DiscountsApplied.Any() is true;
        public List<DiscountApplied> DiscountsApplied { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Guid? SameProductDiscountId { get; set; }
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

        internal BasketProduct ToBasketProduct()
        {
            return new BasketProduct
            {
                Id = Product.Id,
                DiscountsApplied = DiscountsApplied,
                ItemsPrice = Product.Price * Quantity,
                UnitPrice = Product.Price,
                Name = Product.Name,
                Quantity = Quantity
            };
        }
    }
}
