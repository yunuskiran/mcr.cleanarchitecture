using Mcr.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mcr.Mvc.Controllers
{
    public class LeasingController : Controller
    {
        private ILeasingService _leasingService;
        public LeasingController(ILeasingService leasingService)
        {
            _leasingService = leasingService;
        }

        public IActionResult Index()
        {
            var leasingViewModel = _leasingService.GetLeasings();
            return View(leasingViewModel);
        }
    }
}