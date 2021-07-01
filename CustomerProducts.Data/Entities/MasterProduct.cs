using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerProducts.Data.Entities
{
    public sealed partial class MasterProduct
    {
        public MasterProduct()
        {
            MasterCustomerProducts = new HashSet<MasterCustomerProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public ICollection<MasterCustomerProduct> MasterCustomerProducts { get; set; }
    }
}