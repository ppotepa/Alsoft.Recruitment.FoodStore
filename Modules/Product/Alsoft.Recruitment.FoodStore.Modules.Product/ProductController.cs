using Alsoft.Recruitment.FoodStore.Abstractions;
using Alsoft.Recruitment.FoodStore.Modules.Product.Requests.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ModuleController
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)       
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<GetAllProductsRequestResult> GetAllProducts() =>
             await this.mediator.Send(new GetAllProductsRequest());
      
    }
}
