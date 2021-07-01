using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerProducts.Data.Entities
{
    public sealed partial class MasterCity
    {
        public MasterCity()
        {
            MasterCustomerProducts = new HashSet<MasterCustomerProduct>();
        }

        public int CityCode { get; set; }
        public string RegionCode { get; set; }
        public string CityName { get; set; }

        public MasterRegion RegionCodeNavigation { get; set; }
        public ICollection<MasterCustomerProduct> MasterCustomerProducts { get; set; }
    }
}