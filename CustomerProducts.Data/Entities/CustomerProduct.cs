using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProducts.Data.Entities
{
    public class CustomerProduct
    {
        [Key]
        public int Id { get; set; }

        public string CustomerName { get; set; }

        [ForeignKey("CountryCode")]
        public Country Country { get; set; }

        private char CountryCode { get; set; }

        [ForeignKey("RegionCode")]
        public Region Region { get; set; }

        public char RegionCode { get; set; }

        [ForeignKey("CityCode")]
        public City City { get; set; }

        public int CityCode { get; set; }
        public DateTime DateOfSale { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}