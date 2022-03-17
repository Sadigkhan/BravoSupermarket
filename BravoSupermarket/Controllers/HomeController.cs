using BravoSupermarket.DAL;
using BravoSupermarket.Models;
using BravoSupermarket.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BravoSupermarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly BravoDbContext _context;
        public HomeController(BravoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product>products=_context.Products.ToList();
            List<Category> categories = _context.Categories.ToList();


            HomeVM homeVM = new HomeVM
            {
                Products = products,
                Categories = categories
            };
            return View(homeVM);
        }
    }
}
