using Mcr.Application.Interfaces;
using Mcr.Application.ViewModels;
using Mcr.Core.Bus;
using Mcr.Domain.Commands;
using Mcr.Domain.Interfaces;

namespace Mcr.Application.Services
{
    public class LeasingService
        : ILeasingService
    {
        private readonly ILeasingRepository _leasingRepository;
        private readonly IMediatorHandler _mediatorHandler;

        public LeasingService(ILeasingRepository leasingRepository,
            IMediatorHandler mediatorHandler)
        {
            _leasingRepository = leasingRepository;
            _mediatorHandler = mediatorHandler;
        }

        public void CreateLeasing(LeasingViewModel leasingViewModel)
        {
            var command = new CreateLeasingCommand(
                leasingViewModel.WorkOrderId, 
                leasingViewModel.Amount,
                leasingViewModel.Currency);
            _mediatorHandler.SendCommand(command);
        }

        public LeasingViewModel GetLeasings()
            => new LeasingViewModel
            {
                Leasings = _leasingRepository.GetLeasings()
            };
    }
}
