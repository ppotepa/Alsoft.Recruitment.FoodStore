using Alsoft.Recruitment.FoodStore.Abstractions;
using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Alsoft.Recruitment.FoodStore.Entities
{
    public class Discount : Entity
    {
        public Discount(Guid id) : base(id)
        {
        }

        public Discount(string id) : base(id)
        {
        }

        [Required]
        public DateTime DateFrom { get; set; }

        [Required]
        public DateTime DateTo { get; set; }

        [Required]
        public double DiscountPercentage { get; set; }
       
        public DiscountTypeEnumEntity DiscountType { get; set; }

        [Required]
        public Guid DiscountTypeId { get; set; }
        
        public virtual List<DiscountProduct> DiscountProducts { get; set; }

        public Guid? TargetProductId { get; set; }

        public string Name { get; set; }
    }

}