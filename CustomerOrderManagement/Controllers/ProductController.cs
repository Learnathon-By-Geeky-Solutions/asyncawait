using CustomerOrderManagement.Models.EntityModels;
using CustomerOrderManagement.Models.ViewModels.Products;
using CustomerOrderManagement.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CustomerOrderManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            var model = new ProductIndexViewModel
            {
                Products = products.ToList()
            };
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new ProductCreateViewModel
            {
                Products = _productService.GetAll().ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Products = _productService.GetAll().ToList();
                return View(model);
            }

            var product = new Product
            {
                Name = model.Name,
                UnitPrice = model.Price,
                Description = model.Description,
                CategoryId = 1
            };

            _productService.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var product = _productService.GetById(id.Value);
            if (product == null)
            {
                return View("NotFound");
            }

            var model = new ProductEditViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.UnitPrice,
                Description = product.Description,
                id = product.CategoryId
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var existingProduct = _productService.GetById(model.Id);
            if (existingProduct == null)
            {
                return View("NotFound");
            }

            existingProduct.Name = model.Name;
            existingProduct.UnitPrice = model.Price;
            existingProduct.Description = model.Description;

            _productService.Update(existingProduct);
            return RedirectToAction("Index");
        }
    }
}
