using Mcr.Domain.Models;
using System.Collections.Generic;

namespace Mcr.Application.ViewModels
{
    public class LeasingViewModel
    {
        public int WorkOrderId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
