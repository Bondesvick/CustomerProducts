using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerProducts.Data.Entities
{
    public sealed partial class MasterCountry
    {
        public MasterCountry()
        {
            MasterCustomerProducts = new HashSet<MasterCustomerProduct>();
            MasterRegions = new HashSet<MasterRegion>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public ICollection<MasterCustomerProduct> MasterCustomerProducts { get; set; }
        public ICollection<MasterRegion> MasterRegions { get; set; }
    }
}