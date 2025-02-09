using MediatR;

namespace ECommerceApp.Application.Commands
{
    public class UpdateOrderCommand : IRequest<bool>
    {
        public Guid OrderId { get; set; }
        public decimal NewTotalAmount { get; set; }
    }
}
