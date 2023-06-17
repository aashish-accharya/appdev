using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.domain.Shared;

namespace week19.domain.Entities
{
    public class Employee : BaseEntity
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public double Salary { get; set; }
        public string? Position { get; set; }

    }
}
