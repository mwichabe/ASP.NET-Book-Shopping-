using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookStore.Models;

namespace bookStore.Controllers;
public class ProductsController : Controller
{
    private readonly List<Product> _products = new List<Product>();

    public ProductsController()
    {
        // Initialize some sample products
        _products.Add(new Product { Id = 1, Name = "Book 1", Description = "This is a book", Price = 10.99m, Category = "Fiction" });
        _products.Add(new Product { Id = 2, Name = "Book 2", Description = "This is another book", Price = 12.99m, Category = "Non-Fiction" });
        _products.Add(new Product { Id = 3, Name = "Book 3", Description = "This is a third book", Price = 9.99m, Category = "Biography" });
    }

    public IActionResult Index()
    {
        return View(_products);
    }
}