using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class ProductsStockRepository : RepositoryBase<ProductStock>, IProductStockRepository
    {
        public ProductsStockRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public ProductsStockRepository()
        {

        }
    }

    interface IProductStockRepository
    {

    }
}
