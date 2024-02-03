using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;
using MyAkademiMyAkademiECommerce.Services.Catalog.Services.ProductServices;

namespace MyAkademiMyAkademiECommerce.Services.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _ProductServices;

        public ProductsController(IProductServices productServices)
        {
            _ProductServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var values = await _ProductServices.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var values = await _ProductServices.GetProductById(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CerateProduct(CreateProductDto createProductDto)
        {
            await _ProductServices.CreateProductAsync(createProductDto);
            return Ok("Kategori Başarıyla Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _ProductServices.DeleteProductAsync(id);
            return Ok("Kategori Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _ProductServices.UpdateProductAsync(updateProductDto);
            return Ok("Kategori Başarıyla Güncellendi");
        }

    }
}

