using Alsoft.Recruitment.FoodStore.DAL;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Services;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Alsoft.Recruitment.FoodStore.Modules.Basket.Requests.CalculateBasketItem
{
    internal class CalculateBasketRequestHandler : IRequestHandler<CalculateBasketRequest, CalculateBasketRequestResult>
    {
        private readonly BasketCalculationService _basketCalculationService;
        private readonly AlsoftFoodStoreContext _context;
        public CalculateBasketRequestHandler(
                AlsoftFoodStoreContext context,
                BasketCalculationService basketCalculationService
            )
        {
            this._context = context;
            this._basketCalculationService = basketCalculationService;
        }

        public Task<CalculateBasketRequestResult> Handle(CalculateBasketRequest request, CancellationToken cancellationToken)
        {
            BasketCalculationItem[] calculationItems = request.ProductIds
                .GroupBy(id => id)
                .Select(grouping => new BasketCalculationItem(grouping.Key, grouping.Count()))
                .ToArray();

            BasketCalculationDetails calculationDetails = new BasketCalculationDetails
            {
                BasketCalculationItems = calculationItems
            };

            BasketCalculationResult result = _basketCalculationService.CalculateBasket(calculationDetails);

            return Task.FromResult(new CalculateBasketRequestResult { BasketTotal = 99.00m });
        }
    }
}
