using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        public IReport _reportType;

        public ReportGenerator(EmployeeDB employeeDb, IReport ReportType)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _employeeDb = employeeDb;
            _reportType = ReportType;
        }

        public void CompileReport()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }
            
            foreach (var e in employees)
            {
                _reportType.print(e);
            }
        }
    }
}