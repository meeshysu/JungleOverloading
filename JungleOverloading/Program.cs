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
            var tess = new Employee("Tess", "Something");
            var evan = new Employee("Evan", "IForgot");
            var jt = new Employee("Just", "Terrifying");

            var randomChoice = new Employee("Vincent", "Keller");

            catherine.AddEmployees(catherine);
            randomChoice.AddEmployees(randomChoice);
            heather.AddEmployees(heather);
            tess.AddEmployees(tess);
            jt.AddEmployees(jt);
            evan.AddEmployees(evan);

            randomChoice.Eat();
            randomChoice.Eat("sandwich");
            randomChoice.Eat(randomChoice.EmployeeList);

            Console.ReadLine();
        }
    }
}
