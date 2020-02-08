using Mcr.Data.Context;
using Mcr.Domain.Interfaces;
using Mcr.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mcr.Data.Repository
{
    public class LeasingRepository
        : ILeasingRepository
    {
        private readonly LeasingDbContext _leasingDbContext;

        public LeasingRepository(LeasingDbContext leasingDbContext)
        {
            _leasingDbContext = leasingDbContext;
        }

        public void Add(Leasing leasing)
        {
            _leasingDbContext.Add(leasing);
            _leasingDbContext.SaveChanges();
        }

        public IEnumerable<Leasing> GetLeasings()
            => _leasingDbContext.Leasings.ToList();
    }
}
