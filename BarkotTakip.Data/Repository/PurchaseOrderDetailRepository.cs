﻿using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class PurchaseOrderDetailRepository : RepositoryBase<PurchaseOrderDetail>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public PurchaseOrderDetailRepository()
        {

        }
    }

    interface IPurchaseOrderDetailRepository
    {

    }
}
