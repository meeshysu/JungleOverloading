using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public List<Employee> EmployeeList = new List<Employee>();

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddEmployees(Employee newEmployee)
        {
            EmployeeList.Add(newEmployee);
        }

        public List<string> RestaurantList = new List<string>
        {
            "Panera",
            "Just Love",
            "FireHouse Subs",
            "Sir Pizza",
            "City Cafe",
            "Fat Mo's"
        };
    }
}
