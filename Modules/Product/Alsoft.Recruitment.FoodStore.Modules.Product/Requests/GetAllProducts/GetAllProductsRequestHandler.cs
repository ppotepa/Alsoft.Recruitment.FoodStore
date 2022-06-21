using Alsoft.Recruitment.FoodStore.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Alsoft.Recruitment.FoodStore.Modules.Product.Requests.GetAllProducts
{
    internal class GetAllProductsRequestHandler : MediatR.IRequestHandler<GetAllProductsRequest, GetAllProductsRequestResult>
    {
        private readonly AlsoftFoodStoreContext context;

        public GetAllProductsRequestHandler(AlsoftFoodStoreContext context)
        {
            this.context = context;
        }

        public async Task<GetAllProductsRequestResult> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetAllProductsRequestResult
            {
                Products = context.Product
                    .Include(x => x.ProductProperties)
                    .Include(x => x.UnitType)
                    .ToList()
            });
        }
    }
}