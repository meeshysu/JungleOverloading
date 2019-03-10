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


        public string RandomRestaurant()
        {
            Random unplanned = new Random();
            int unplannedRestaurantChoice = unplanned.Next(RestaurantList.Count);
            return (RestaurantList[unplannedRestaurantChoice]);
        }

        public void Eat()
        {
            Console.WriteLine($"{FirstName} {LastName} is eating at {RandomRestaurant()}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} brought back this {food} and ate it at the office.");
        }

        public void Eat(List<Employee> companions)
        {
            string[] employeesFriend = { "Tess", "Catherine", "Evan", "JT", "Heather" };
            Random rand = new Random();
            int index = rand.Next(employeesFriend.Length);
            foreach (var companion in companions)
            Console.WriteLine($"{FirstName} went to {RandomRestaurant()} with {employeesFriend[index]}.");
        }
    }
}

