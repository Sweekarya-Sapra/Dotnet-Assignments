using System;
using System.Collections.Generic;

namespace NS.EMS.API.Entities
{
    public partial class Emp
    {
        public long EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}
