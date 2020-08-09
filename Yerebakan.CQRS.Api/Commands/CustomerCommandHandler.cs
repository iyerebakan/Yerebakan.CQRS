using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Yerebakan.CQRS.Api.Data;
using Yerebakan.CQRS.Api.Events;
using Yerebakan.CQRS.Api.Models;
using Yerebakan.CQRS.Core.Commands;
using Yerebakan.CQRS.Core.Events;

namespace Yerebakan.CQRS.Api.Commands
{
    public class CustomerCommandHandler : ICommandHandler<CreateCustomer>
    {
        private readonly IEventBus _eventBus;
        public CustomerCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task<Unit> Handle(CreateCustomer request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            (
                id: Guid.NewGuid(),
                name: request.Name,
                taxno: request.TaxNo,
                title: request.Title
            );
            CustomerData.Customers.Add(customer);
            await _eventBus.Publish(customer.PendingEvents.ToArray());
            return Unit.Value;
        }
    }
}
