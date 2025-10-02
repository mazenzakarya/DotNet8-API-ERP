using Erp.BL.DTOs.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Services.Product
{
    public interface IProductServies
    {
        // Define methods for managing products, e.g., GetProducts, GetProductById, CreateProduct, UpdateProduct, DeleteProduct
        List<ProductDto> GetProducts();

        ProductDto GetProductById(Guid id);

        void CreateProduct(ProductDto product);

        void UpdateProduct(Guid id, ProductDto product);

        void DeleteProduct(Guid id);
    }
}