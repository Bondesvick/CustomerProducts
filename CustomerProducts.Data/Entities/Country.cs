using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProducts.Data.Entities
{
    [Table("Master_Country")]
    public class Country
    {
        [Key]
        [Column("CountryCode")]
        private char CountryCode { get; set; }

        [Column("CountryName")]
        public string CountryName { get; set; }

        public List<Region> Regions { get; set; }
    }
}