using Erp.BL.DTOs.NewFolder;
using Erp.DAL.Data.Repositories.NewFolder;
using Erp.DAL.Data.Models;

using Erp.DAL.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Services.Product
{
    public class ProductServies : IProductServies
    {
        private readonly IProductRepository _repo;

        public ProductServies(IProductRepository repo)
        {
            _repo = repo;
        }

        public void CreateProduct(ProductDto product)
        {
            _repo.CreateProduct(new DAL.Data.Models.Product
            {
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            });
        }

        public void DeleteProduct(Guid id)
        {
            _repo.DeleteProduct(id);
        }

        public ProductDto GetProductById(Guid id)
        {
            var GetProductById = _repo.GetProductById(id);
            return new ProductDto
            {
                Name = GetProductById.Name,
                Price = GetProductById.Price,
                Quantity = GetProductById.Quantity
            };
        }

        public List<ProductDto> GetProducts()
        {
            var GetAllProduct = _repo.GetProducts();
            return GetAllProduct.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            }).ToList();
        }

        public void UpdateProduct(Guid id, ProductDto product)
        {
            var ProductetToUpdate = _repo.GetProductById(id);
            ProductetToUpdate.Name = product.Name;
            ProductetToUpdate.Price = product.Price;
            ProductetToUpdate.Quantity = product.Quantity;
        }
    }
}