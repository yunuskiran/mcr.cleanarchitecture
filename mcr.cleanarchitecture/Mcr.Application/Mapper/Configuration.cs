using AutoMapper;

namespace Mcr.Application.Mapper
{
    public class Configuration
    {
        public static MapperConfiguration RegisterMappings()
            => new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new ViewModelDomainProfile());
                configuration.AddProfile(new DomainViewModelProfile());
            });
    }
}
