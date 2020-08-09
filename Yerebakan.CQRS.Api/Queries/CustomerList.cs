using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yerebakan.CQRS.Api.Models;
using Yerebakan.CQRS.Core.Queries;

namespace Yerebakan.CQRS.Api.Queries
{
    public class CustomerList : IQuery<CustomerList>
    {
        public List<Customer> Customers { get; set; }
    }
}
