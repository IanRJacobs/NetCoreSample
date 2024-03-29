﻿using System;
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
    public class ScopedProductController : Controller
    {
        private IProductServiceScoped _productService;
        private IProductRepositoryScoped _productRepositoryScoped;
        public ScopedProductController(IProductServiceScoped productService, IProductRepositoryScoped productRepositoryScoped)
        {
            _productService = productService;
            _productRepositoryScoped = productRepositoryScoped;
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
            _productRepositoryScoped.Add();
        }
    }
}