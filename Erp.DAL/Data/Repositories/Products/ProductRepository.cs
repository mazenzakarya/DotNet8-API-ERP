using Erp.DAL.Data.ContractorsContext;
using Erp.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DAL.Data.Repositories.NewFolder
{
    public class ProductRepository : IProductRepository
    {
        private readonly ErpContext db;

        public ProductRepository(ErpContext db)
        {
            this.db = db;
        }

        public void CreateProduct(Product product)
        {
            var existingProduct = db.Products.FirstOrDefault(p => p.Name.ToLower() == product.Name.ToLower());
            if (existingProduct != null)
            {
                throw new Exception("Product with the same name already exists.");
            }
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(Guid id)
        {
            var productToDelete = GetProductById(id);
            if (productToDelete != null)
            {
                db.Products.Remove(productToDelete);
                db.SaveChanges();
            }
        }

        public Product GetProductById(Guid id)
        {
            var ProductById = db.Products.Find(id);
            if (ProductById != null)
            {
                return ProductById;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public List<Product> GetProducts()
        {
            var getAllProducts = db.Products.ToList();
            return getAllProducts;
        }

        public void UpdateProduct(Guid id, Product product)
        {
            var current = GetProductById(id);
            if (current != null)
            {
                current.Name = product.Name;
                current.Price = product.Price;
                current.Quantity = product.Quantity;
                db.SaveChanges();
            }
        }
    }
}