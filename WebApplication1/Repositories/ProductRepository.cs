using WebApplication1.Models.Domain;
using WebApplication1.Models.Data;
namespace WebApplication1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context) => _context = context;
        public Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = _context.Product.ToList();
            return Task.FromResult<IEnumerable<Product>>(products);
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            var product = _context.Product.Find(id);
            return Task.FromResult(product);
        }

        public Task<bool> DeleteAsync(Product product)
        {
            var existingProduct = _context.Product.Find(product.Id);
            if (existingProduct == null)
            {
                return Task.FromResult(false);
            }
            else
            {
                _context.Product.Remove(existingProduct);
                _context.SaveChanges();
                return Task.FromResult(true);
            }
        }

        public Task<bool> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}