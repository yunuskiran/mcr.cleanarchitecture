using Mcr.Application.Interfaces;
using Mcr.Application.Services;
using Mcr.Bus;
using Mcr.Core.Bus;
using Mcr.Data.Context;
using Mcr.Data.Repository;
using Mcr.Domain.CommandHandlers;
using Mcr.Domain.Commands;
using Mcr.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Mcr.Installer
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddDomain(ref services);
            AddApplicationLayer(ref services);
            AddDataLayer(ref services);
            AddDbContext(ref services);
        }

        private static void AddDbContext(ref IServiceCollection services)
        {
            services.AddScoped<LeasingDbContext>();
        }

        private static void AddDomain(ref IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<IRequestHandler<CreateLeasingCommand, bool>, LeasingCommandHandler>();
        }

        private static void AddDataLayer(ref IServiceCollection services)
        {
            services.AddScoped<ILeasingRepository, LeasingRepository>();
        }

        private static void AddApplicationLayer(ref IServiceCollection services)
        {
            services.AddScoped<ILeasingService, LeasingService>();
        }
    }
}
