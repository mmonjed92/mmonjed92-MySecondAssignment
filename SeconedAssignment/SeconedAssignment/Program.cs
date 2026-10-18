using System;
using System.Collections.Generic;
using System.Text;

using SeconedAssignment;



    Employee full = new FullTimeEmployee(1, "ahmad", 1200m);
    Employee part = new PartTimeEmployee(2, "omar", 80m, 5m);



    Console.WriteLine("Enter Employee ID");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Name");
    string name = Console.ReadLine();
    Console.WriteLine("Select 1- Full Time or 2- Part Time");
    int salarymethod = Convert.ToInt32(Console.ReadLine());

    if (salarymethod == 1)
    {

        Console.WriteLine("Enter Monthly Salary:");
        decimal salary = Convert.ToDecimal(Console.ReadLine());
        full = new FullTimeEmployee(id, name, salary);
        full.DisplayInfo();
        full.work();
    }

    else if (salarymethod == 2)
    {
        Console.WriteLine("Enter Hours Worked:");
        decimal hours = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter Hourly Rate:");
        decimal rate = Convert.ToDecimal(Console.ReadLine());
        part = new PartTimeEmployee(id, name, hours, rate);
        part.DisplayInfo();
        part.work();

    }

    else
    {

        Console.WriteLine("Salary not found");
    }

       


 