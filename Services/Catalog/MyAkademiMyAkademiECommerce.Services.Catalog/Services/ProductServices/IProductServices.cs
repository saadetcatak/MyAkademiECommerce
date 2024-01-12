using MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;
using MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;

namespace MyAkademiMyAkademiECommerce.Services.Catalog.Services.ProductServices
{
    public interface IProductServices
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<ResultProductDto> GetProductById(string id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
       
    }
}
