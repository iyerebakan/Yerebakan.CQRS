using System.Collections.Generic;
using Yerebakan.CQRS.Core.Aggregates;

namespace Yerebakan.CQRS.Core.Events
{
    public interface IEventSourcedAggregate : IAggregate
    {
        Queue<IEvent> PendingEvents { get; }
    }
}
