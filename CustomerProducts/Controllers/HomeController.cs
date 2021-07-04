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
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public async Task<IActionResult> LoadRegions(string countryCode)
        {
            var regions = await _customerProductService.GetRegions();
            regions = regions.Where(x => x.CountryCode == countryCode).ToList();

            return Json(new SelectList(regions, "RegionCode", "RegionName"));
        }

        public async Task<IActionResult> LoadCities(string regionCode)
        {
            var cities = await _customerProductService.GetCities();
            cities = cities.Where(x => x.RegionCode == regionCode).ToList();

            return Json(new SelectList(cities, "CityCode", "CityName"));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var countries = await _customerProductService.GetCountries();
            var products = await _customerProductService.GetProducts();

            ViewBag.Countries = countries;

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
                _customerProductService.Add(masterCustomerProduct);

                return RedirectToAction("Index", "Home");
            }

            var countries = await _customerProductService.GetCountries();
            var products = await _customerProductService.GetProducts();

            ViewBag.Countries = countries;
            ViewBag.Products = products;

            ViewBag.Action = "Add Customer Product";

            return View(masterCustomerProduct);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}