using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models.Enums;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.SalesRecord.Any())
            {
                return; //nesse caso, o banco já foi populado
            }

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 11, 23), 11000.0, SalesStatus.Billed);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 09, 25), 11000.0, SalesStatus.Canceled);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2017, 01, 15), 11000.0, SalesStatus.Pending);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2015, 05, 05), 11000.0, SalesStatus.Billed);

            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4);
            _context.SaveChanges();
        }
    }
}
