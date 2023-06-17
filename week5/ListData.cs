using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    internal class ListData
    {
        public static void NewList(string name) {
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
            List<EmployeeModel> searchList = list.Where(x => x.Name.Contains(name)).ToList();
            if (searchList.Count > 0)
            {
                foreach (var item in searchList)
                {
                    Console.WriteLine(item.Name + ", " + item.Address + ", " + item.Age);
                }
            }
            else {
                Console.WriteLine("Name not found");
            }

            //sort list
            Console.WriteLine("Sorted list");
            List<SampleModel> sortList = list.OrderBy(x => x.CreatedAt).ToList();
            List<SampleModel> sortList1 = list.OrderByDescending(x => x.CreatedAt).ToList();
        }
    }
}
