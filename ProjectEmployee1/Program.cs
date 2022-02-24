using ProjectEmployee1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEmployee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine());
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHours, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment());
            }
            Console.ReadLine();
        }
    }
}
