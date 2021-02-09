using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class PurchaseOrderDto
    {
        public int PurchaseOrderId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> IsApporeved { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual Products Products { get; set; }
    }
}
