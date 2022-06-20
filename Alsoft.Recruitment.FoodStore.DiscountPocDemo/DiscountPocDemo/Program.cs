using System;
using System.Linq;

namespace DiscountPocDemo
{
    internal partial class Program
    {
        internal enum DiscountType
        {
            SameProduct = 1,
            OtherProduct,
            AllProducts
        }

        internal class Discount
        {
            public int Id { get; set; }
            public int[] ProductIds { get; set; }
            public DateTime From { get; set; }
            public DateTime To { get; set; }
            public DiscountType DiscountType { get; set; }
            public double DiscountPercentage { get; set; }
        }

        static void Main(string[] args)
        {
            Product[] products = new[]
            {
               new Product
               {
                   Id = 1,
                   Name = "Apple",
                   Price = 10
               },

               new Product
               {
                   Id = 2,
                   Name = "Soup",
                   Price = 20
               },

               new Product
               {
                   Id = 3,
                   Name = "Roll",
                   Price = 5
               },

               new Product
               {
                   Id = 4,
                   Name = "Milk",
                   Price = 6
               },

                new Product
               {
                   Id = 5,
                   Name = "Bread",
                   Price = 11
               },
           };

            Discount[] discounts = new Discount[]
            {
                new Discount
                {
                    Id = 1,
                    DiscountPercentage = 0.1d,
                    DiscountType = DiscountType.SameProduct,
                    From = DateTime.MinValue,
                    To = DateTime.MaxValue,
                    ProductIds = new[] { 1 },
                }
            };

            var basket = new[] { 1, 1, 1, 1, 1 };

            var basketProcessed = basket.GroupBy(x => x).Select(x => new { Id = x.Key, Count = x.Count() }).ToList();
            var discountsToBeApplied = discounts.Where(x => x.ProductIds.Intersect(basketProcessed.Select(x => x.Id)).Count() == x.ProductIds.Count());
        }
    }
}
