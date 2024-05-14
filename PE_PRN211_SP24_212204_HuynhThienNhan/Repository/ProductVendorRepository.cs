using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductVendorRepository
    {
        private ConvenienceStoreDbContext _context = new ConvenienceStoreDbContext();
        
        public List<Vendor> GetVendor()
        {
            _context = new();
            return _context.Vendors.ToList();
        }
    }
}
