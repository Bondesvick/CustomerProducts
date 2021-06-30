using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProducts.Data.Entities
{
    [Table("Master_Product")]
    public class Product
    {
        [Key]
        [Column("ProductID")]
        public int ProductID { get; set; }

        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }
    }
}