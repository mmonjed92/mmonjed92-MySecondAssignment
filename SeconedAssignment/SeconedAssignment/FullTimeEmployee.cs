using System;
using System.Collections.Generic;
using System.Text;

namespace SeconedAssignment
{
    public class FullTimeEmployee : Employee,IWorkable
    {
        private decimal _monthlySalary;

        public FullTimeEmployee(int id, string name, decimal monthlySalary) : base(id, name)
        {
            _monthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return _monthlySalary;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employee Type: Full-Time");
            Console.WriteLine($"Salary: {CalculateSalary()} JOD");
        }

        public override void work()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }
    }
}
