using PiNkYpeach.Api.Data.Entities;

namespace PiNkYpeach.Api.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategory(int id); 
    }
}
