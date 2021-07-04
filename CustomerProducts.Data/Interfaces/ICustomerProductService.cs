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
        void Add(MasterCustomerProduct customerProduct);

        Task<List<MasterCustomerProduct>> GetCustomerProducts();

        Task<List<MasterCustomerProduct>> GetCustomerProductsByDate();

        Task<List<MasterCustomerProduct>> GetCustomerProductsByCountry();

        Task<List<MasterCustomerProduct>> GetCustomerProductsByRegion();

        Task<List<MasterCustomerProduct>> GetCustomerProductsByCity();

        Task<List<MasterProduct>> GetProducts();

        //Task<List<MasterProduct>> GetProducts2();

        //Task<List<MasterCountry>> GetCountries();
        Task<List<MasterCountry>> GetCountries();

        Task<List<MasterRegion>> GetRegions();

        Task<List<MasterCity>> GetCities();
    }
}