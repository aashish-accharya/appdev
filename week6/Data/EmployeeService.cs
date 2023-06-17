using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using week6.Data.Model;

namespace week6.Data
{
	internal class EmployeeService
	{
		public static List<EmployeeModel> NewList()
		{
			List<EmployeeModel> list = new List<EmployeeModel>()
			{
				new EmployeeModel{Name="Piyash",Age=20, Address="Bal", HireDate=DateTime.Now.AddDays(1)},
				new EmployeeModel{Name="name2",Age=21, Address="Lok", HireDate=DateTime.Now.AddDays(2)},
				new EmployeeModel{Name="name3",Age=22, Address="Kot", HireDate=DateTime.Now.AddDays(3)},
				new EmployeeModel{Name="name4",Age=23, Address="Thi", HireDate=DateTime.Now.AddDays(4)},
				new EmployeeModel{Name="name5",Age=21, Address="Rad", HireDate=DateTime.Now.AddDays(5)},
				new EmployeeModel{Name="name6",Age=25, Address="Kau", HireDate=DateTime.Now.AddDays(6)},
				new EmployeeModel{Name="name7",Age=26, Address="Lal", HireDate=DateTime.Now.AddDays(7)},
				new EmployeeModel{Name="name8",Age=23, Address="New", HireDate=DateTime.Now.AddDays(8)},
				new EmployeeModel{Name="name9",Age=26, Address="Bul", HireDate=DateTime.Now.AddDays(9)},
				new EmployeeModel{Name="name10",Age=21, Address="Tha", HireDate=DateTime.Now.AddDays(1)}
			};
			return list;
		}

		/*	public static void searchList(string name) { 
				List<EmployeeModel> searchList = NewList().list.Where(x => x.Name.Contains(name)).ToList();
				if (searchList.Count > 0)
				{
					foreach (var item in searchList)
					{
						Console.WriteLine(item.Name + ", " + item.Address + ", " + item.Age);
					}
				}
				else
				{
					Console.WriteLine("Name not found");
				}

				//sort list
				Console.WriteLine("Sorted list");
				List<SampleModel> sortList = list.OrderBy(x => x.CreatedAt).ToList();
				List<SampleModel> sortList1 = list.OrderByDescending(x => x.CreatedAt).ToList();
			}*/

		public List<EmployeeModel> asc()
		{
			return (NewList().OrderBy(x => x.HireDate).ToList());
		}

		public List<EmployeeModel> desc()
		{
			return (NewList().OrderByDescending(x => x.HireDate).ToList());
		}
	}
}
