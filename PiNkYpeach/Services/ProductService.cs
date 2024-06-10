using Microsoft.EntityFrameworkCore;
using PiNkYpeach.Api.Data;
using PiNkYpeach.Api.Data.Entities;
using PiNkYpeach.Api.Services.Interfaces;

namespace PiNkYpeach.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationContext _context;
        public ProductService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await _context.ProductCategories.ToListAsync();
            return categories;  
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}
