using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public class ProductsRepository : RepositoryBase<Products>,IProductsRepository
    {

        public ProductsRepository(MarketBarkodDBEntities context) : base(context)
        {
        }

        public ProductsRepository()
        {

        }
     
    }

    interface IProductsRepository
    {

    }
}
