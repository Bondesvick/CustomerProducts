using CustomerProducts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CustomerProducts.Data.Entities;
using CustomerProducts.Data.Interfaces;

namespace CustomerProducts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerProductService _customerProductService;

        public HomeController(ILogger<HomeController> logger, ICustomerProductService customerProductService)
        {
            _logger = logger;
            _customerProductService = customerProductService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var countries = await _customerProductService.GetCountries();
            var regions = await _customerProductService.GetRegions();
            var cities = await _customerProductService.GetCities();
            var products = await _customerProductService.GetProducts();

            ViewBag.Countries = countries;
            ViewBag.Regions = regions;
            ViewBag.Cities = cities;

            ViewBag.Products = products;

            ViewBag.Action = "Add Customer Product";

            var customerProduct = new MasterCustomerProduct();

            return View(customerProduct);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MasterCustomerProduct masterCustomerProduct)
        {
            if (ModelState.IsValid)
            {
                //return View();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var countries = await _customerProductService.GetCountries();
                var regions = await _customerProductService.GetRegions();
                var cities = await _customerProductService.GetCities();
                var products = await _customerProductService.GetProducts();

                ViewBag.Countries = countries;
                ViewBag.Regions = regions;
                ViewBag.Cities = cities;

                ViewBag.Products = products;

                ViewBag.Action = "Add Customer Product";

                return View(masterCustomerProduct);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}