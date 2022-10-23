using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string employeeName = employeeInfo[0];
                decimal employeeSalary = decimal.Parse(employeeInfo[1]);
                string departmentName = employeeInfo[2];

                Employee employee = new Employee(employeeName, employeeSalary);

                if (!departments.Any(department=>department.Name==departmentName))
                {
                    Department department = new Department(departmentName, new List<Employee>());
                    departments.Add(department);
                }

                departments[departments.IndexOf(departments.First(x => x.Name == departmentName))].Employees.Add(employee);
            }

            departments = departments.OrderByDescending(x => x.Employees.Average(y => y.Salary)).ToList();

            Console.WriteLine($"Highest Average Salary: {departments[0].Name}");
            Console.WriteLine($"{departments[0]}");
        }
    }

    class Employee
    {
        public Employee(string name, decimal salaty)
        {
            Name = name;
            Salary = salaty;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Name} {this.Salary:f2}");

            return sb.ToString();
        }
    }

    class Department
    {
        public Department(string name, List<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            foreach (Employee empl in this.Employees.OrderByDescending(x=>x.Salary))
            {
                sb.AppendLine($"{empl}");
            }

            return sb.ToString();
        }
    }
}
