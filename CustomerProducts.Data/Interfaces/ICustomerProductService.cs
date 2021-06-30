using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerProducts.Data.Entities;

namespace CustomerProducts.Data.Interfaces
{
    public interface ICustomerProductService
    {
        Task Add(CustomerProduct customerProduct);

        Task<List<CustomerProduct>> GetCustomerProducts();

        Task<List<CustomerProduct>> GetCustomerProductsByDate();

        Task<List<CustomerProduct>> GetCustomerProductsByCountry();

        Task<List<CustomerProduct>> GetCustomerProductsByRegion();

        Task<List<CustomerProduct>> GetCustomerProductsByCity();

        Task<List<Product>> GetProducts();

        Task<List<Country>> GetCountries();

        Task<List<Region>> GetRegions();

        Task<List<City>> GetCities();
    }
}