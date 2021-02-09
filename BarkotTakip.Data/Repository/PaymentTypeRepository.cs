
using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BarkotTakip.Data.Repository
{
    public  class PaymentTypeRepository : RepositoryBase<PaymentType>, IPaymentTypeRepository
    {
        public PaymentTypeRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public PaymentTypeRepository()
        {

        }
    }

    interface IPaymentTypeRepository
    {

    }
}
