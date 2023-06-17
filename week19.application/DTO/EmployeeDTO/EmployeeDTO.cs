using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week19.application.DTO.EmployeeDTO
{
    public class EmployeeDTO
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public double Salary { get; set; }
        public string? Position { get; set; }

    }
}
