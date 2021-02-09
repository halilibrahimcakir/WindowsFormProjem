using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class OrderDetailsRepository : RepositoryBase<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public OrderDetailsRepository()
        {

        }
    }

    interface IOrderDetailsRepository
    {

    }
}
