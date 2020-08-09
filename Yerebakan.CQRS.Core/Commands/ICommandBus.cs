using System.Threading.Tasks;

namespace Yerebakan.CQRS.Core.Commands
{
    public interface ICommandBus
    {
        Task Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
