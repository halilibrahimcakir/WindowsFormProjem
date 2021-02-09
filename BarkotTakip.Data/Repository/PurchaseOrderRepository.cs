using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class PurchaseOrderRepository : RepositoryBase<PurchaseOrder>, ICategoriesRepository
    {
        public PurchaseOrderRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public PurchaseOrderRepository()
        {

        }
    }

    interface IPurchaseOrderRepository
    {

    }
}
