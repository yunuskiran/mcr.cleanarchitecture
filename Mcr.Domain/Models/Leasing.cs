namespace Mcr.Domain.Models
{
    public class Leasing
    {
        public int Id { get; set; }
        public int WorkorderId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
