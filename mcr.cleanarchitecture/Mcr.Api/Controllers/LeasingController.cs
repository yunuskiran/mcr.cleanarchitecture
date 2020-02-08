using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mcr.Application.Interfaces;
using Mcr.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mcr.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeasingController : ControllerBase
    {
        private readonly ILeasingService _leasingService;
        public LeasingController(ILeasingService leasingService)
        {
            _leasingService = leasingService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LeasingViewModel leasingViewModel)
        {
            _leasingService.CreateLeasing(leasingViewModel);

            return Ok(leasingViewModel);
        }
    }
}
