using MediatR;
using System;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Requests.CalculateBasketItem
{
    internal class CalculateBasketRequest : IRequest<CalculateBasketRequestResult>
    {
        public Guid[] ProductIds { get; set; }
    }
}
