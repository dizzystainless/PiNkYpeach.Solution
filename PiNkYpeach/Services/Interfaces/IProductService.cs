namespace PiNkYpeach.Data.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetItems();
    }
}
