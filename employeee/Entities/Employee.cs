using System;
using System.Collections.Generic;
using System.Text;

namespace employeee.Entities
{
    class Employee
    {
        public string  name { get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return hours * valuePerHour;
        }
    }
}
