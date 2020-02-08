using Mcr.Application.ViewModels;
using System.Collections.Generic;

namespace Mcr.Application.Interfaces
{
    public interface ILeasingService
    {
        LeasingViewModel GetLeasings();

        void CreateLeasing(LeasingViewModel leasingViewModel);
    }
}
