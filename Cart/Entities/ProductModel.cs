using System.Collections.Generic;
using System.Linq;

namespace Cart.Demo.Entities
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product {
                    Id = "p01",
                    Name = "iPhone 12 Pro I Chính hãng VN/A",
                    Price = 27300000,
                    Photo = "iphone12.jpg"
                },
                new Product {
                    Id = "p02",
                    Name = "Laptop Macbook Air 2020",
                    Price = 60000000,
                    Photo = "macbook.jpg"
                },
                new Product {
                    Id = "p03",
                    Name = "Samsung Galaxy S21 5G",
                    Price = 20990000,
                    Photo = "samsung.jpg"
                },
                new Product {
                    Id = "p04",
                    Name = "iPad Pro 2020",
                    Price = 23790000,
                    Photo = "ipad.jpg"
                }
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }

    }
}