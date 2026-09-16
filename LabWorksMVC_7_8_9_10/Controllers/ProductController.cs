using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.Intrinsics.X86;
using static System.Collections.Specialized.BitVector32;

namespace LabWorksMVC_7_8_9_10.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Gaming Laptop",
                Description = "High-performance laptop for gaming",
                Brand = "Lenovo",
                Category = "Electronics",
                Price = 120000,
                Discount = 10,
                StockQuantity = 15,
                IsAvailable = true,
                Rating = 4.5,
                Color = "Black",
                Size = "15.6 inch",
                SKU = "LEN-GAM-001",
                CreatedDate = DateTime.Now
            },

            new Product
            {
                Id = 2,
                Name = "iPhone 15",
                Description = "Apple smartphone with advanced camera",
                Brand = "Apple",
                Category = "Mobile",
                Price = 130000,
                Discount = 5,
                StockQuantity = 20,
                IsAvailable = true,
                Rating = 4.7,
                Color = "Blue",
                Size = "6.1 inch",
                SKU = "APP-IP15-002",
                CreatedDate = DateTime.Now
            },

            new Product
            {
                Id = 3,
                Name = "Galaxy S24",
                Description = "Premium Android smartphone",
                Brand = "Samsung",
                Category = "Mobile",
                Price = 110000,
                Discount = 8,
                StockQuantity = 25,
                IsAvailable = true,
                Rating = 4.6,
                Color = "Silver",
                Size = "6.2 inch",
                SKU = "SAM-S24-003",
                CreatedDate = DateTime.Now
            },

            new Product
            {
                Id = 4,
                Name = "Wireless Headphones",
                Description = "Noise-cancelling wireless headphones",
                Brand = "Sony",
                Category = "Audio",
                Price = 35000,
                Discount = 15,
                StockQuantity = 30,
                IsAvailable = true,
                Rating = 4.4,
                Color = "Black",
                Size = "Over-Ear",
                SKU = "SON-WH-004",
                CreatedDate = DateTime.Now
            },

            new Product
            {
                Id = 5,
                Name = "Mechanical Keyboard",
                Description = "RGB mechanical keyboard for gaming",
                Brand = "Logitech",
                Category = "Computer Accessories",
                Price = 12000,
                Discount = 10,
                StockQuantity = 40,
                IsAvailable = true,
                Rating = 4.3,
                Color = "White",
                Size = "Full Size",
                SKU = "LOG-MK-005",
                CreatedDate = DateTime.Now
            }
        };
        public class Product
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Brand { get; set; }

            public string Category { get; set; }

            public decimal Price { get; set; }

            public decimal Discount { get; set; }

            public int StockQuantity { get; set; }

            public bool IsAvailable { get; set; }

            public double Rating { get; set; }

            public string Color { get; set; }

            public string Size { get; set; }

            public string SKU { get; set; }

            public DateTime CreatedDate { get; set; }
        }
        //1. In the Index action of the ProductController, return a View that displays a list of products.
        public IActionResult Index()
        {
            return View(products);
        }

        //2. Add a new action GetProductInfo in ProductController that returns product information in JSON format.

        public IActionResult GetProductInfo(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Json(product);
        }
        //3. Add a new action RedirectToHome in ProductController that returns a RedirectResult to the home page(i.e., Home/Index).

        public IActionResult RedirectToHome()
        {
            return Redirect("/Home/Index");
        }
        //4. Add a new action DownloadProductFile in ProductController that returns a file for
        //download.You can use a simple text file or image as the content.[File]
        public IActionResult DownloadProductFile(int id)
        {
            var fileName = $"{id}image.jpeg";

            var filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "files",
                fileName
            );

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            return PhysicalFile(
                filePath,
                "image/jpeg",
                fileName
            );
        }
        //        5. Add a new action DisplayMessage in ProductController that returns a simple string
        //message using ContentResult.

        public IActionResult DisplayMessage()
        {
            return Content("Welcome to the Product Management System!");
        }

        //6. Add a new action ReturnStatusCode in ProductController that returns a custom HTTP
        //status code(e.g., 204 No Content).[StatusCodeResult]
        public IActionResult ReturnStatusCode()
        {
            return StatusCode(204);
        }
    }
}
