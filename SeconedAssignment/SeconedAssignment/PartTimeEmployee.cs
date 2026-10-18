using System;
using System.Collections.Generic;
using System.Text;

namespace SeconedAssignment
{
    public class PartTimeEmployee : Employee, IWorkable
    {
        private decimal _hoursWorked;
        private decimal _hourlyRate;

        public PartTimeEmployee(int id, string name, decimal hoursWorked, decimal hourlyRate) : base(id, name)
        {
            _hoursWorked = hoursWorked;
            _hourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            return _hoursWorked * _hourlyRate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employee Type: Part-Time");
            Console.WriteLine($"Salary: {CalculateSalary()} JOD");
           
        }

        public override void work()
        {
            Console.WriteLine($"{Name} is working part-time.");
        }
    }
}
