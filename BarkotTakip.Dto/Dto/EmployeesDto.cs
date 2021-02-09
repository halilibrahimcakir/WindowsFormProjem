﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkotTakip.Dto.Dto
{
    public class EmployeesDto
    {
        public int EmployeeId { get; set; }
        public Nullable<int> UserTypeId { get; set; }
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<short> Phone { get; set; }
        public string Adress { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string Title { get; set; }
        public Nullable<int> ReportsTo { get; set; }
    }
}
