using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercise
{
    public class SalariedEmployee : Employee
    {
        public double Salary { get; set; }

        public SalariedEmployee(int id, string name, double salary) : base(id, name)
        {
            Salary = salary;
        }

        public override double Earnings()
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSalary = {Salary:C}";
        }
    }
}
