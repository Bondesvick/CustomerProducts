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
        private readonly masterContext _masterContext;
        private readonly ILogger<CustomerProductService> _logger;

        public CustomerProductService(
            masterContext masterContext,
            ILogger<CustomerProductService> logger)
        {
            _masterContext = masterContext;
            _logger = logger;
        }

        public Task Add(MasterCustomerProduct customerProduct)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MasterCustomerProduct>> GetCustomerProducts()
        {
            try
            {
                return await _masterContext.MasterCustomerProducts.FromSqlRaw("EXEC dbo.spGetCustomerProducts").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterCustomerProduct>> GetCustomerProductsByDate()
        {
            try
            {
                return await _masterContext.MasterCustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterCustomerProduct>> GetCustomerProductsByCountry()
        {
            try
            {
                return await _masterContext.MasterCustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterCustomerProduct>> GetCustomerProductsByRegion()
        {
            try
            {
                return await _masterContext.MasterCustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterCustomerProduct>> GetCustomerProductsByCity()
        {
            try
            {
                return await _masterContext.MasterCustomerProducts.FromSqlRaw("").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterProduct>> GetProducts()
        {
            try
            {
                return await _masterContext.MasterProducts.FromSqlRaw("EXEC dbo.spGetProducts").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterCountry>> GetCountries()
        {
            try
            {
                var result = _masterContext.MasterCountries.FromSqlInterpolated($"SELECT * FROM [master].[dbo].[Master_Country]");
                var final = await result
                    .Include(x => x.MasterRegions)
                    .ThenInclude(x => x.MasterCities).ToListAsync();

                return final;
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public async Task<List<MasterRegion>> GetRegions()
        {
            try
            {
                return await _masterContext.MasterRegions.FromSqlRaw("EXEC dbo.spGetRegions").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }

        public Task<List<MasterCity>> GetCities()
        {
            try
            {
                return _masterContext.MasterCities.FromSqlRaw("EXEC dbo.spGetCities").ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error: {e.Message}", e.ToString());
                throw;
            }
        }
    }
}