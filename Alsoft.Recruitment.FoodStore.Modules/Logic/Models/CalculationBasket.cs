using System.Collections.Generic;
using System.Linq;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models
{
    public class CalculationBasket
    {
        public List<BasketProductLine> Products { get; internal set; }
        public decimal Total 
            => Products.Sum(binding => binding.Quantity * binding.Product.Price);
       
    }
}