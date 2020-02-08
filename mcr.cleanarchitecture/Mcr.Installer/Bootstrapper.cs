using Mcr.Application.Interfaces;
using Mcr.Application.Services;
using Mcr.Data.Repository;
using Mcr.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Mcr.Installer
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddApplicationLayer(ref services);
            AddDataLayer(ref services);
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
