using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerProducts.Data.Entities
{
    public sealed partial class MasterRegion
    {
        public MasterRegion()
        {
            MasterCities = new HashSet<MasterCity>();
            MasterCustomerProducts = new HashSet<MasterCustomerProduct>();
        }

        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionName { get; set; }

        public MasterCountry CountryCodeNavigation { get; set; }
        public ICollection<MasterCity> MasterCities { get; set; }
        public ICollection<MasterCustomerProduct> MasterCustomerProducts { get; set; }
    }
}