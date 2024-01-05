using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyAkademiMyAkademiECommerce.Services.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductImage { get; set; }     
        public string CategoryID { get; set; }
    }
}
