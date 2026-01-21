using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercise
{
    public class HourlyEmployee : Employee
    {
        public int Hours { get; set; }
        public double Wage { get; set; }

        public HourlyEmployee(int id, string? name, int hours, double wage) : base(id, name)
        {
            Hours = hours;
            Wage = wage;
        }

        public override double Earnings()
        {
            if (Hours <= 40)
                return Hours * Wage;
            else
                return (40 * Wage) + (Hours - 40) * Wage * 1.5;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nHours = {Hours}\nWage = {Wage:C}";
        }
    }
}
