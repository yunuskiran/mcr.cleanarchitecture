using AutoMapper;
using Mcr.Application.ViewModels;
using Mcr.Domain.Commands;

namespace Mcr.Application.Mapper
{
    public class ViewModelDomainProfile
        : Profile
    {
        public ViewModelDomainProfile()
        {
            CreateMap<LeasingViewModel, CreateLeasingCommand>()
                .ConstructUsing(c => new CreateLeasingCommand(
                    c.WorkOrderId,
                    c.Amount,
                    c.Currency));
        }
    }
}
