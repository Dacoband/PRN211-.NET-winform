using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductVendorService
    {
        public List<Vendor> GetAllVendor()
        {
            ProductVendorRepository _repo = new ProductVendorRepository();
            return _repo.GetVendor();

        }
    }
}
