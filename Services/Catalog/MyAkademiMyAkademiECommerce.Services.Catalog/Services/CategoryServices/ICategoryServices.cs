using MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;

namespace MyAkademiMyAkademiECommerce.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryServices
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
       Task< ResultCategoryDto> GetCategoryById(string id);
    }
}
