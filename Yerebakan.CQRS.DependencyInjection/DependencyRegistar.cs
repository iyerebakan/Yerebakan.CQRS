using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;
using Yerebakan.CQRS.Core.Commands;
using Yerebakan.CQRS.Core.Events;
using Yerebakan.CQRS.Core.Queries;

namespace Yerebakan.CQRS.DependencyInjection
{
    public static class DependencyRegistar
    {
        public static IServiceCollection CQRSRegisterService(this IServiceCollection services)
        {
            services.AddScoped<IQueryBus, QueryBus>();
            services.AddScoped<ICommandBus, CommandBus>();
            services.AddScoped<IEventBus, EventBus>();

            return services;
        }
    }
}
