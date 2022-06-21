using Alsoft.Recruitment.FoodStore.Abstractions;
using Alsoft.Recruitment.FoodStore.Entities.Enumerations.DiscountType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Alsoft.Recruitment.FoodStore.Entities
{
    public class Discount : Entity
    {
        public Discount()
        {
        }

        public Discount(Guid id) : base(id)
        {
        }

        public Discount(string id) : base(id)
        {
        }

        [Required]
        [NotNull]
        public DateTime? DateFrom { get; set; }

        [Required]
        [NotNull]
        public DateTime? DateTo { get; set; }

        [Required]
        public double DiscountPercentage { get; set; }
       
        public DiscountTypeEnumEntity DiscountType { get; set; }

        [Required]
        public Guid DiscountTypeId { get; set; }
        
        public virtual List<DiscountProduct> DiscountProducts { get; set; }

        public Guid? TargetProductId { get; set; }

        public string Name { get; set; }

        public int? DiscountQuantity { get; set; }
    }

}