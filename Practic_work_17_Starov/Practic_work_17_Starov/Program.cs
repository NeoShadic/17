using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_17_Starov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            var c1 = new Color(255, 128, 0);
            var c2 = c1;
            c2.R = 100;
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // Задание 2
            var order1 = new Order { Id = 1001, Total = 1500.50m };
            var order2 = order1;

            order2.Total = 2000.00m;

            Console.WriteLine(order1.Total);
            Console.WriteLine(order1);

            // Задание 3
            var f = new File { Permissions = FileAccess.Read | FileAccess.Write };

            Console.WriteLine(f.CanRead());
            Console.WriteLine(f.CanWrite());
            Console.WriteLine(f.CanExecute());

            // Задание 4
            var w1 = new Weather { City = "Москва", Temperature = 22.5 };
            var w2 = new Weather { City = "Сочи", Temperature = null };

            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w2.Temperature ?? -999);

            // Задание 5
            var emp = new Employee
            {
                Name = "Пётр",
                HireDate = new DateTime(2020, 3, 15),
                Status = EmploymentStatus.Active
            };

            Console.WriteLine(emp.GetYearsWorked());
            emp.HireDate = null;
            Console.WriteLine(emp.GetYearsWorked());
            Console.WriteLine(emp);
        }
    }
}
