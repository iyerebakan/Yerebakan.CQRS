using MediatR;

namespace Yerebakan.CQRS.Core.Events
{
    public interface IEventHandler<in TEvent>: INotificationHandler<TEvent>
           where TEvent : IEvent
    {
    }
}
