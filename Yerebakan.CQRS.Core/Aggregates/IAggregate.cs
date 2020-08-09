using System;
using System.Collections.Generic;
using System.Text;

namespace Yerebakan.CQRS.Core.Aggregates
{
    public interface IAggregate
    {
        Guid Id { get; }
    }
}
