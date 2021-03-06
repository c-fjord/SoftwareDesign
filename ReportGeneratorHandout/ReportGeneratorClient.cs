﻿using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000, 32));
            db.AddEmployee(new Employee("Berit", 2000, 45));
            db.AddEmployee(new Employee("Christel", 1000, 54));
            
            IReport ReportType = new AgeFirst();

            var reportGenerator = new ReportGenerator(db, ReportType);

            // Create a default (name-first) report
            reportGenerator.CompileReport();

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            reportGenerator._reportType = new SalaryFirst();
            reportGenerator.CompileReport();

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a age-first report
            reportGenerator._reportType = new AgeFirst();
            reportGenerator.CompileReport();
        }
    }
}