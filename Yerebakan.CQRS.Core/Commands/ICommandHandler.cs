using MediatR;

namespace Yerebakan.CQRS.Core.Commands
{
    public interface ICommandHandler<in T>: IRequestHandler<T>
        where T : ICommand
    {
    }
}
