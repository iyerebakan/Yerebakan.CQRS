using Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Yerebakan.CQRS.Api.Data;
using Yerebakan.CQRS.Api.Models;

namespace Yerebakan.CQRS.Api.Queries
{
    public class CustomerQueryHandler : 
        IQueryHandler<CustomerList, CustomerList>,
        IQueryHandler<CustomerById,Customer>
    {
        private CustomerList customerList;
        public CustomerQueryHandler()
        {
            customerList = new CustomerList();
            customerList.Customers = CustomerData.Customers;
        }
        public Task<CustomerList> Handle(CustomerList request, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(customerList);
        }

        public async Task<Customer> Handle(CustomerById request, CancellationToken cancellationToken)
        {
            return Task.FromResult(customerList.Customers.Where(t => t.Id == request.Id).FirstOrDefault()).Result;
        }
    }
}
