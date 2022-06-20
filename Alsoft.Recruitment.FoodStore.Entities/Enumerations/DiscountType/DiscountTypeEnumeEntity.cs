using Alsoft.Recruitment.FoodStore.Abstractions;
using System;
using System.Collections.Generic;

namespace Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType
{
    public class DiscountTypeEnumEntity : EnumerableEntity<DiscountType>
    {
        public DiscountTypeEnumEntity()
        {
        }

        public DiscountTypeEnumEntity(string id) : base(id)
        {
        }

        public DiscountTypeEnumEntity(Guid id) : base(id)
        {
        }

        public virtual List<Discount> Discounts { get; set; }
    }
}