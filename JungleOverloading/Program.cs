using System;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var catherine = new Employee("Catherine", "Chandler");
            var vincent = new Employee("Vincent", "Keller");
            var heather = new Employee("Heather", "Chandler");

            catherine.AddEmployees(catherine);
            vincent.AddEmployees(vincent);
            heather.AddEmployees(heather);


        }
    }
}
