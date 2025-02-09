using ECommerceApp.Application.Queris;
using ECommerceApp.Domain;
using ECommerceApp.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Application.QueryHandlers
{
    public class GetOrdersHandler : IRequestHandler<GetOrdersQuery, List<Order>>
    {
        private readonly ApplicationDbContext _context;

        public GetOrdersHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.ToListAsync(cancellationToken);
        }
    }
}
