using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yerebakan.CQRS.Api.Models;

namespace Yerebakan.CQRS.Api.Data
{
    public static class CustomerData
    {
        static CustomerData()
        {
            Customers = new List<Customer>
            {
                new Customer( id : Guid.NewGuid(), name: "ilk müşteri", title: "ilk müşteri title", taxno: "12345"),
                new Customer( id : Guid.NewGuid(), name: "ikinci müşteri", title: "ikinci müşteri title", taxno: "67890"),
                new Customer( id : Guid.NewGuid(), name: "üçüncü müşteri", title: "üçüncü müşteri title", taxno :"13579"),
                new Customer(id: Guid.NewGuid(), name: "dördüncü müşteri", title: "dördüncü müşteri title", taxno: "02468")
            };
        }
        public static List<Customer> Customers { get; set; }
    }
}
