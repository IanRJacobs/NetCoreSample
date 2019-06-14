using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Infrastructure;
using Application;
using MVCexample.Models;

namespace MVCexample.Controllers
{
    public class SingletonProductController : Controller
    {
        private IProductServiceSingleton _productService;
        private IProductRepositorySingleton _productRepositorySingleton;
        public SingletonProductController(IProductServiceSingleton productService, IProductRepositorySingleton productRepositorySingleton)
        {
            _productService = productService;
            _productRepositorySingleton = productRepositorySingleton;
        }
        public ActionResult Index()
        {
            AddTwo();
            ProductListViewModel model = new ProductListViewModel(_productService.GetAll());
            return View(model);
        }
        public ActionResult Add()
        {
            AddTwo();
            return RedirectToAction("Index");
        }

        public void AddTwo()
        {
            _productRepositorySingleton.Add();
        }
    }
}