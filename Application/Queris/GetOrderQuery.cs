using ECommerceApp.Domain;
using MediatR;

namespace ECommerceApp.Application.Queris
{
    public class GetOrderQuery : IRequest<Order>
    {
        public Guid OrderId { get; set; }
    }

}
