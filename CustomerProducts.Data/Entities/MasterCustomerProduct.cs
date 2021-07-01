using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CustomerProducts.Data.Entities
{
    public partial class MasterCustomerProduct
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter customer name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please select country")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Please select region")]
        public string RegionCode { get; set; }

        [Required(ErrorMessage = "Please select city")]
        public int CityCode { get; set; }

        [Required(ErrorMessage = "Please select product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter product quantity")]
        public int Quantity { get; set; }

        public virtual MasterCity CityCodeNavigation { get; set; }
        public virtual MasterCountry CountryCodeNavigation { get; set; }
        public virtual MasterProduct Product { get; set; }
        public virtual MasterRegion RegionCodeNavigation { get; set; }
    }
}