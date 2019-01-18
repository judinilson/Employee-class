using System;
using System.Collections.Generic;
using System.Globalization;
using employeee.Entities;

namespace employeee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();


            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i <=n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced(y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePHour, additionalCharge));
                }else
                {
                    list.Add(new Employee(name, hours, valuePHour));
                }

              
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENT: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.name + "- $" +
                    emp.Payment().ToString("F3", CultureInfo.InvariantCulture));
            }
        }
    }
}
