using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Weak", 3.5, Position.Middle);
            Console.WriteLine($"Salary: {employee.Salary,0:0.00}");
            Console.WriteLine($"Tax: {employee.Tax}");
        }
    }
}
