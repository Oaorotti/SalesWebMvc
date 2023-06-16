using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

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
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Food");

            Seller s1 = new Seller(1, "James", "james@gmail.com", 1000, new DateTime(1990, 03, 04), d1);
            Seller s2 = new Seller(2, "Robson", "Robson@gmail.com", 3000, new DateTime(1985, 02, 05), d2);
            Seller s3 = new Seller(3, "Alex", "alex@gmail.com", 5000, new DateTime(1974, 04, 03), d3);
            Seller s4 = new Seller(4, "Rachel", "Rachel@gmail.com", 900, new DateTime(2005, 02, 07), d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(1990, 02, 01), 1000, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(1992, 03, 05), 4000, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(1996, 07, 03), 1000, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(sr1, sr2, sr3);

            _context.SaveChanges();
        }
    }
}
