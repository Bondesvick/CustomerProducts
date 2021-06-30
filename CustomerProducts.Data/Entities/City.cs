using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProducts.Data.Entities
{
    [Table("Master_City")]
    public class City
    {
        [Key]
        [Column("CityCode")]
        public int CityCode { get; set; }

        [ForeignKey("RegionCode")]
        public Region Region { get; set; }

        [Column("RegionCode")]
        public char RegionCode { get; set; }

        [Column("CityName")]
        public string CityName { get; set; }
    }
}