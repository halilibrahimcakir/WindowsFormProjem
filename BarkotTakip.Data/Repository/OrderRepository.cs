using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class OrdersRepository : RepositoryBase<Orders>, IOrdersRepository
    {
        public OrdersRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public OrdersRepository()
        {

        }
    }

    interface IOrdersRepository
    {

    }
}
