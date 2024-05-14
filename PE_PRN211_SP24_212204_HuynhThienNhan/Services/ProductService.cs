using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        private ProductRepository _repo = new ProductRepository();
        public List<Product> GetAllProducts()
        {
            return _repo.GetProduct();
        }
        public void AddAProduct(Product product)
        {
            _repo.CreateProduct(product);
        }
        public void DeleteAProduct(Product product)
        {
            _repo.DeleteProduct(product);
        }
        public void UpdateAProduct(Product product)
        {
            _repo.UpdateProduct(product);
        }
    }
}
