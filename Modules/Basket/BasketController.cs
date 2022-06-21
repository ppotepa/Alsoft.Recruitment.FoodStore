using Alsoft.Recruitment.FoodStore.Abstractions;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Requests.CalculateBasketItem;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BasketController : ModuleController
    {
        private readonly IMediator mediator;

        public BasketController(IMediator mediator)       
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<CalculateBasketRequestResult> CalculateBasketTotal(Guid[] productIds) =>
             await this.mediator.Send(new CalculateBasketRequest { ProductIds = productIds });
      
    }
}
