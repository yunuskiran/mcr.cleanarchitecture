using Mcr.Domain.Commands;
using Mcr.Domain.Interfaces;
using Mcr.Domain.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mcr.Domain.CommandHandlers
{
    public class LeasingCommandHandler
        : IRequestHandler<CreateLeasingCommand, bool>
    {
        private readonly ILeasingRepository _leasingRepository;
        public LeasingCommandHandler(ILeasingRepository leasingRepository)
        {
            _leasingRepository = leasingRepository;
        }

        public Task<bool> Handle(CreateLeasingCommand request, CancellationToken cancellationToken)
        {
            var leasing = new Leasing
            {
                WorkorderId = request.WorkorderId,
                Amount = request.Amount,
                Currency = request.Currency
            };

            _leasingRepository.Add(leasing);
            return Task.FromResult(true);
        }
    }
}
