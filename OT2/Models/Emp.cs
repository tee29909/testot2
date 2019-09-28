using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OT2.Models
{
    public class Emp
    {
        public string EmpID { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Line { get; set; }
        public string Call { get; set; }
        public string Addr { get; set; }
        public string Image { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string LocationName { get; set; }
        public string EmployeeTypeID { get; set; }
        public string PositionID { get; set; }
    }
}
