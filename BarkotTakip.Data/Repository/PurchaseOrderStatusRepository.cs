using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class PurchaseOrderStatusRepository : RepositoryBase<PurchaseOrderStatus>, IPurchaseOrderStatusRepository
    {
        public PurchaseOrderStatusRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public PurchaseOrderStatusRepository()
        {

        }
    }

    interface IPurchaseOrderStatusRepository
    {

    }
}
