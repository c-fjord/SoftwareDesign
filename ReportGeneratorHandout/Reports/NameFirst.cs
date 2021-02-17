using System;

namespace ReportGenerator
{
    class NameFirst : IReport
    {
        public void print(Employee e)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Name: {0}", e.Name);
            Console.WriteLine("Salary: {0}", e.Salary);
            Console.WriteLine("Age: {0}", e.Age);
            Console.WriteLine("------------------");
        }
    }
}