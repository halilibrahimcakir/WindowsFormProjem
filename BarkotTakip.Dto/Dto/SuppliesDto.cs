﻿using BarkotTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class SuppliesDto
    {

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }

   
        public virtual ICollection<Products> Products { get; set; }
    }
}
