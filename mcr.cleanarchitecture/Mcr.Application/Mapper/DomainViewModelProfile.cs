using AutoMapper;
using Mcr.Application.ViewModels;
using Mcr.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
