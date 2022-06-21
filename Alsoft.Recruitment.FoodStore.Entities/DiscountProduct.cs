using Alsoft.Recruitment.FoodStore.Abstractions;
using System;

namespace Alsoft.Recruitment.FoodStore.Entities
{
    public class DiscountProduct : Entity
    {
        public DiscountProduct()
        {
        }

        public DiscountProduct(Guid id) : base(id)
        {
        }

        public DiscountProduct(string id) : base(id)
        {
        }

        public Guid DiscountId { get; set; }
        public Guid ProductId { get; set; }
        public Discount ParentDiscount { get; set; }
    }

}