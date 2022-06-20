using Alsoft.Recruitment.FoodStore.Abstractions;
using System;
using System.Collections.Generic;

namespace Alsoft.Recruitment.FoodStore.Entities.Enumerations.UnitType
{
    public class UnitTypeEnumEntity : EnumerableEntity<UnitType>
    {
        public UnitTypeEnumEntity()
        {
        }

        public UnitTypeEnumEntity(string id) : base(id)
        {
        }

        public UnitTypeEnumEntity(Guid id) : base(id)
        {
        }

        public virtual List<Product> Products { get; set; }
    }
}