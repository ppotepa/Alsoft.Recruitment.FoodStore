using Alsoft.Recruitment.FoodStore.Abstractions;
using Alsoft.Recruitment.FoodStore.Entities.Enumerations.UnitType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Alsoft.Recruitment.FoodStore.Entities
{
    public class Product : Entity
    {
        public Product(Guid id) : base(id) { }
        public Product(string id) : base(id) { }

        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ProductProperty> ProductProperties { get; set; }
        public UnitTypeEnumEntity UnitType { get; set; }

        [Required]
        public Guid UnitTypeId { get; set; }
    }
}
