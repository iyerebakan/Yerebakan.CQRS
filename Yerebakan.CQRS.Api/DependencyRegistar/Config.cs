using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yerebakan.CQRS.Api.Commands;
using Yerebakan.CQRS.Api.Events;
using Yerebakan.CQRS.Api.Models;
using Yerebakan.CQRS.Api.Queries;
using Yerebakan.CQRS.Core.Events;

namespace Yerebakan.CQRS.Api.DependencyRegistar
{
    public static class Config
    {
        public static void AddCommandHandlers(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateCustomer, Unit>, CustomerCommandHandler>();
        }

        public static void AddQueryHandlers(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CustomerById, Customer>, CustomerQueryHandler>();
            services.AddScoped<IRequestHandler<CustomerList, CustomerList>, CustomerQueryHandler>();
        }

        public static void AddEventHandler(IServiceCollection services)
        {
            services.AddScoped<INotificationHandler<CustomerCreated>, CustomerEventHandler2>();
            services.AddScoped<INotificationHandler<CustomerCreated>, CustomerEventHandler>();
        }

    }
}
