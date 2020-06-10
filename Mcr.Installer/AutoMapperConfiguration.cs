using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Mcr.Installer
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterAutoMapper(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(typeof(Mcr.Application.Mapper.Configuration));
            Mcr.Application.Mapper.Configuration.RegisterMappings();
        }
    }
}
