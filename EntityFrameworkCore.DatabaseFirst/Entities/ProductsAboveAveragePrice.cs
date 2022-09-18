using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkCore.DatabaseFirst.Entities
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
