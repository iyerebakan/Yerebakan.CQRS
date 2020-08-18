using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yerebakan.CQRS.Api.Events;
using Yerebakan.CQRS.Core.Events;

namespace Yerebakan.CQRS.Api.Models
{
    public class Customer : EventSourcedAggregate
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string TaxNo { get; private set; }


        public Customer()
        {
        }

        public Customer(Guid id, string name, string title, string taxno)
        {
            Id = id;
            Name = name;
            Title = title;
            TaxNo = taxno;

            Append(new CustomerCreated(id: id, name: name, title: title, taxNo: taxno));
            //Append(new CustomerCreated(id: id, name: name, title: title, taxNo: taxno));
        }
    }
}
