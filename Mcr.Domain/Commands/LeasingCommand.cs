using Mcr.Core.Commands;

namespace Mcr.Domain.Commands
{
    public abstract class LeasingCommand
        : Command
    {
        public int Id { get; set; }
        public int WorkorderId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
