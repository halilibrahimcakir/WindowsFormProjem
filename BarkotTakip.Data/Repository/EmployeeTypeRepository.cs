using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BarkotTakip.Data.Repository
{
    public  class EmployeeTypeRepository : RepositoryBase<EmployeeType>, IEmployeeTypeRepository
    {
        public EmployeeTypeRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public EmployeeTypeRepository()
        {

        }
    }

    interface IEmployeeTypeRepository
    {

    }
}
