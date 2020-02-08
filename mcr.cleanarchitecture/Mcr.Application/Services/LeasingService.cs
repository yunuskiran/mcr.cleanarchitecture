using AutoMapper;
using AutoMapper.QueryableExtensions;
using Mcr.Application.Interfaces;
using Mcr.Application.ViewModels;
using Mcr.Core.Bus;
using Mcr.Domain.Commands;
using Mcr.Domain.Interfaces;
using System.Collections.Generic;

namespace Mcr.Application.Services
{
    public class LeasingService
        : ILeasingService
    {
        private readonly ILeasingRepository _leasingRepository;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IMapper _mapper;

        public LeasingService(ILeasingRepository leasingRepository,
            IMediatorHandler mediatorHandler,
            IMapper mapper)
        {
            _leasingRepository = leasingRepository;
            _mediatorHandler = mediatorHandler;
            _mapper = mapper;
        }

        public void CreateLeasing(LeasingViewModel leasingViewModel)
         => _mediatorHandler.SendCommand(_mapper
                .Map<CreateLeasingCommand>(leasingViewModel));

        public IEnumerable<LeasingViewModel> GetLeasings()
            => _leasingRepository.GetLeasings()
                .ProjectTo<LeasingViewModel>(_mapper.ConfigurationProvider);
    }
}
