using System.Collections.Generic;

namespace Alsoft.Recruitment.FoodStore.Modules.Product.Requests.GetAllProducts
{
    public class GetAllProductsRequestResult
    {
        public List<Entities.Product> Products { get; set; }
    }
}