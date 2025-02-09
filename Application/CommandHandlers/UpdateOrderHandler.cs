using ECommerceApp.Application.Commands;
using ECommerceApp.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Application.CommandHandlers
{
    public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand, bool>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UpdateOrderHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _applicationDbContext.Orders.FindAsync(request.OrderId);
            if (order == null) return false;
            order.TotalAmount = request.NewTotalAmount;
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
