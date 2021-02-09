using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public class InvoceRepository : RepositoryBase<Invoce>, IInvoceRepository
    {
        public InvoceRepository(MarketBarkodDBEntities contex) : base(contex)
        {

            
        }

        public InvoceRepository()
        {

        }

    }

    internal interface IInvoceRepository
    {
    }
}
