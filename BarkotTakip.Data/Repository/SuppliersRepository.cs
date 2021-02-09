using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class SuppliersRepository : RepositoryBase<Suppliers>, ISuppliesRepository
    {
        public SuppliersRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public SuppliersRepository()
        {

        }
    }

    interface ISuppliesRepository
    {

    }
}
