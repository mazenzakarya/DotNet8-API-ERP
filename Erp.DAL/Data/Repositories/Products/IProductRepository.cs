using Erp.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DAL.Data.Repositories.NewFolder
{
    public interface IProductRepository
    {
        // Define methods for managing products, e.g., GetProducts, GetProductById, CreateProduct, UpdateProduct, DeleteProduct
        List<Product> GetProducts();

        Product GetProductById(Guid id);

        void CreateProduct(Product product);

        void UpdateProduct(Guid id, Product product);

        void DeleteProduct(Guid id);
    }
}