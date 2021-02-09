using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class CustomersDto
    {
        public int CustomerId { get; set; }
        public string NameSurname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public Nullable<decimal> WillGive { get; set; }
    }
}
