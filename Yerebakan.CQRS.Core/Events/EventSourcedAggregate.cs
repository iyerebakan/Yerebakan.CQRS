using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Yerebakan.CQRS.Core.Events
{
    public abstract class EventSourcedAggregate: IEventSourcedAggregate
    {
        public Guid Id { get; protected set; }

        [JsonIgnore]
        public Queue<IEvent> PendingEvents { get; private set; }

        protected EventSourcedAggregate()
        {
            PendingEvents = new Queue<IEvent>();
        }

        protected void Append(IEvent @event)
        {
            PendingEvents.Enqueue(@event);
        }
    }
}
