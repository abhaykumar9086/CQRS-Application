using ECommerceApp.Application.Commands;
using ECommerceApp.Domain;
using ECommerceApp.Infrastructure;
using MediatR;

namespace ECommerceApp.Application.CommandHandlers
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly ApplicationDbContext _context;
        public CreateOrderHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CustomerName = request.CustomerName,
                TotalAmount = request.TotalAmount
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.Id;
        }
    }
}
