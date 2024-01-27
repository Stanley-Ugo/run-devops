using Shopping.Client.Models;
using System.Collections.Generic;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Name = "IPhone X",
                Description = "This iphone is the biggest flagship to its comapny.",
                ImageFile = "product-1.png",
                Price = 959.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Samsung 10",
                Description = "This iphone is the biggest flagship to its comapny.",
                ImageFile = "product-2.png",
                Price = 500.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "IPhone 11",
                Description = "This iphone is the biggest flagship to its comapny.",
                ImageFile = "product-3.png",
                Price = 470.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Samsung Fold",
                Description = "This iphone is the biggest flagship to its comapny.",
                ImageFile = "product-4.png",
                Price = 380.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Huawei Plus",
                Description = "This iphone is the biggest flagship to its comapny.",
                ImageFile = "product-5.png",
                Price = 380.00M,
                Category = "White Appliances"
            },
            new Product
            {
                Name = "Xiaomi Mi 9",
                Description = "This iphone is the biggest flagship to its comapny.",
                ImageFile = "product-6.png",
                Price = 380.00M,
                Category = "White Appliances"
            }
        };
    }
}
