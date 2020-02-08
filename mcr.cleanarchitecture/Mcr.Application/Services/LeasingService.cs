using Mcr.Application.Interfaces;
using Mcr.Application.ViewModels;
using Mcr.Domain.Interfaces;

namespace Mcr.Application.Services
{
    public class LeasingService
        : ILeasingService
    {
        private ILeasingRepository _leasingRepository;

        public LeasingService(ILeasingRepository leasingRepository)
        {
            _leasingRepository = leasingRepository;
        }

        public LeasingViewModel GetLeasings()
            => new LeasingViewModel
            {
                Leasings = _leasingRepository.GetLeasings()
            };
    }
}
