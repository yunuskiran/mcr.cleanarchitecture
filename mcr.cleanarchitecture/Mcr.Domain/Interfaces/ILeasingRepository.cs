using Mcr.Domain.Models;
using System.Collections.Generic;

namespace Mcr.Domain.Interfaces
{
    public interface ILeasingRepository
    {
        IEnumerable<Leasing> GetLeasings();
        void Add(Leasing leasing);
    }
}
