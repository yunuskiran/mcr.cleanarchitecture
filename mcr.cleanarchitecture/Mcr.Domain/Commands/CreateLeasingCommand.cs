namespace Mcr.Domain.Commands
{
    public class CreateLeasingCommand
        : LeasingCommand
    {
        public CreateLeasingCommand(int workOrderId, decimal amount,
            string currency)
        {
            this.WorkorderId = workOrderId;
            this.Amount = amount;
            this.Currency = currency;
        }
    }
}
