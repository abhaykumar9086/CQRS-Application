using ECommerceApp.Domain;
using MediatR;

namespace ECommerceApp.Application.Queris
{
    public class GetOrdersQuery : IRequest<List<Order>>
    {
    }
}
