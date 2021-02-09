﻿using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class EmployeesRepository : RepositoryBase<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public EmployeesRepository()
        {

        }
    }

    interface IEmployeesRepository
    {

    }
}
