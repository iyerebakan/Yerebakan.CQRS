using System.Threading.Tasks;

namespace Yerebakan.CQRS.Core.Events
{
    public interface IEventBus
    {
        Task Publish<TEvent>(params TEvent[] events) where TEvent : IEvent;
    }
}