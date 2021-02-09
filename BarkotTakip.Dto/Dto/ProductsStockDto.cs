using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class ProductsStockDto
    {
        public int ProductStockId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> UnitPrice { get; set; }

        public virtual Products Products { get; set; }
    }
}
