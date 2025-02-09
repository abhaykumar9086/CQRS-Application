using ECommerceApp.Application.Queris;
using ECommerceApp.Domain;
using ECommerceApp.Infrastructure;
using MediatR;

namespace ECommerceApp.Application.QueryHandlers
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, Order>
    {
        private readonly ApplicationDbContext _context;

        public GetOrderHandler(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.FindAsync(request.OrderId);
        }
    }
}
