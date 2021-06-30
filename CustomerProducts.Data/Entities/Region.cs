using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProducts.Data.Entities
{
    [Table("Master_Region")]
    public class Region
    {
        [Key]
        [Column("RegionCode")]
        public char RegionCode { get; set; }

        [ForeignKey("CountryCode")]
        public Country Country { get; set; }

        [Column("CountryCode")]
        public char CountryCode { get; set; }

        [Column("RegionName")]
        public string RegionName { get; set; }

        public List<City> Cities { get; set; }
    }
}