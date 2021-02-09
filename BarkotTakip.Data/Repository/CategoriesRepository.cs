﻿using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Data.Repository
{
    public  class CategoriesRepository : RepositoryBase<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public CategoriesRepository()
        {

        }
    }

    interface ICategoriesRepository
    {

    }
}
