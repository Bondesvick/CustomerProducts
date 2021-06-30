using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerProducts.Data.Entities;
using CustomerProducts.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CustomerProducts.Data.Services
{
    public class CustomerProductService : ICustomerProductService
    {
        private readonly ProductContext _productContext;
        private readonly ILogger<CustomerProductService> _logger;

        public CustomerProductService(ProductContext productContext, ILogger<CustomerProductService> logger)
        {
            _productContext = productContext;
            _logger = logger;
        }

        public Task Add(CustomerProduct customerProduct)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerProduct>> GetCustomerProducts()
        {
            try
            {
                return _productContext.CustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<CustomerProduct>> GetCustomerProductsByDate()
        {
            try
            {
                return _productContext.CustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<CustomerProduct>> GetCustomerProductsByCountry()
        {
            try
            {
                return _productContext.CustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<CustomerProduct>> GetCustomerProductsByRegion()
        {
            try
            {
                return _productContext.CustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<CustomerProduct>> GetCustomerProductsByCity()
        {
            try
            {
                return _productContext.CustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<Product>> GetProducts()
        {
            return _productContext.Products.FromSqlRaw("EXEC dbo.spGetProducts").ToListAsync();
        }

        public Task<List<Country>> GetCountries()
        {
            try
            {
                return _productContext.Countries.FromSqlRaw("EXEC dbo.spGetCountries").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<Region>> GetRegions()
        {
            try
            {
                return _productContext.Regions.FromSqlRaw("EXEC dbo.spGetRegions").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<City>> GetCities()
        {
            try
            {
                return _productContext.Cities.FromSqlRaw("EXEC dbo.spGetCities").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }
    }
}