using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerProducts.Data.Interfaces;
using Microsoft.Extensions.Logging;

namespace CustomerProducts.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ICustomerProductService _customerProductService;

        public ProductController(ILogger<ProductController> logger, ICustomerProductService customerProductService)
        {
            _logger = logger;
            _customerProductService = customerProductService;
        }

        public async Task<IActionResult> Index()
        {
            var requests = await _customerProductService.GetCustomerProducts();
            return View();
        }
    }
}