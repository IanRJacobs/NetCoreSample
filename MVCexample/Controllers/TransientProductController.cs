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
    public class TransientProductController : Controller
    {
        private IProductServiceTransient _productService;
        private IProductRepositoryTransient _productRepositoryTransient;
        public TransientProductController(IProductServiceTransient productService, IProductRepositoryTransient productRepository)
        {
            _productService = productService;
            _productRepositoryTransient = productRepository;
        }
        public ActionResult Index()
        {
            AddOne();
            ProductListViewModel model = new ProductListViewModel(_productService.GetAll());
            return View(model);
        }
        public ActionResult Add()
        {
            AddOne();
            return RedirectToAction("Index");
        }

        public void AddOne()
        {
            _productRepositoryTransient.Add();
        }
    }
}