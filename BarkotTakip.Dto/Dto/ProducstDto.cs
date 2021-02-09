using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class ProducstDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> UnitsInStock { get; set; }
        public Nullable<bool> Discount { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }

        public virtual Categories Categories { get; set; }
        
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        
        public virtual ICollection<ProductStock> ProductStock { get; set; }
        
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
