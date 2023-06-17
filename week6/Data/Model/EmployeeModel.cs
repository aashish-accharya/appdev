using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6.Data.Model
{
	internal class EmployeeModel
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set; }
		public int Age { get; set; }
		public string Address { get; set; }
		public DateTime HireDate { get; set; }
	}
}
