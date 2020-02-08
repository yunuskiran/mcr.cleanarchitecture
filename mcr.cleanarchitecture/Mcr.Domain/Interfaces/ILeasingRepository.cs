using Mcr.Domain.Models;
using System.Linq;

namespace Mcr.Domain.Interfaces
{
    public interface ILeasingRepository
    {
        IQueryable<Leasing> GetLeasings();
        void Add(Leasing leasing);
    }
}
