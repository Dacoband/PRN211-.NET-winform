using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository
    {
        private ConvenienceStoreDbContext _context = new ConvenienceStoreDbContext();
        public List<Product> GetProduct()
        {
            _context = new();
            return _context.Products.ToList();
        }
        public void CreateProduct(Product product)
        {
            _context = new();
            _context.Products.Add(product);
            _context.SaveChanges();
        } //Check trùng key : ChatGPT -> How to handle duplicate of primary key in C# using EF core when inserting a new book in Book Management app 
        public void UpdateProduct(Product product)
        {
            _context = new();
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            _context = new();
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
