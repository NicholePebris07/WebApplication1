using WebApplication1.Models.Dto;
using WebApplication1.Models.Domain;

namespace WebApplication1.Services
{
    public interface IProductService
    {
       Task<IEnumerable<ProductDto>> GetAllAsync(object id);
        Task<ProductDto?> GetByIdAsync(int id);
        Task<ProductDto> CreateAsync(CreateProductDto input);
        object? CreateAsync(Product product);
        Task GetByIdAsync(object id);
    }
}
