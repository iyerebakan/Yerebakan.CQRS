using MediatR;

namespace Yerebakan.CQRS.Core.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
