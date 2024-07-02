using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopZooKalininWpf.Class.Papka.Services
{
    public class ProductService
    {
        public List<Products> GetProducts()
        {
            using (var context = new ShopZooKalininEntities1())
            {
                return context.Products.ToList();
            }
        }

        public void AddProduct(Products product)
        {
            using (var context = new ShopZooKalininEntities1())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void EditProduct(Products product)
        {
            using (var context = new ShopZooKalininEntities1())
            {
                var existingProduct = context.Products.Find(product.Id_products);
                if (existingProduct != null)
                {
                    existingProduct.Name = product.Name;

                    context.SaveChanges();
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            using (var context = new ShopZooKalininEntities1())
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
        }
    }
}

