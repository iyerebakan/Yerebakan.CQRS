using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yerebakan.CQRS.Core.Commands;

namespace Yerebakan.CQRS.Api.Commands
{
    public class CreateCustomer : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string TaxNo { get; set; }
    }
}
