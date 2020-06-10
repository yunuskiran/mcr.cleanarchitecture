using AutoMapper;
using Mcr.Application.ViewModels;
using Mcr.Domain.Models;

namespace Mcr.Application.Mapper
{
    public class DomainViewModelProfile
        : Profile
    {
        public DomainViewModelProfile()
        {
            CreateMap<Leasing, LeasingViewModel>();
        }
    }
}
