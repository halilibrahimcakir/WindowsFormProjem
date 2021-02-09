using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> EmployeId { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
