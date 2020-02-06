using Mcr.Domain.Models;
using System.Collections.Generic;

namespace Mcr.Application.ViewModels
{
    public class LeasingViewModel
    {
        public IEnumerable<Leasing> Leasings { get; set; }
    }
}
