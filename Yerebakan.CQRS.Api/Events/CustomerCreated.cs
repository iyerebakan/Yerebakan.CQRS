using System;
using Yerebakan.CQRS.Core.Events;

namespace Yerebakan.CQRS.Api.Events
{
    public class CustomerCreated : IEvent
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Title { get; }
        public string TaxNo { get; }

        public CustomerCreated(string taxNo, string title, string name, Guid id)
        {
            TaxNo = taxNo;
            Title = title;
            Name = name;
            Id = id;
        }
    }
}
