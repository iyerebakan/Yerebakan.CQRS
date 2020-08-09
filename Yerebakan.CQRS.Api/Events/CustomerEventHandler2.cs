using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Yerebakan.CQRS.Core.Events;

namespace Yerebakan.CQRS.Api.Events
{
    public class CustomerEventHandler2 : IEventHandler<CustomerCreated>
    {
        public async Task Handle(CustomerCreated notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("CustomerEventHandler2 works.!");
        }
    }
}
