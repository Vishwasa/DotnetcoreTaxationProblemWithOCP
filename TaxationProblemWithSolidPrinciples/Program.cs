using System;

namespace TaxationProblemWithSolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee vishwas = new Employee();
            vishwas.Name = "Vishwas SL";
            vishwas.Salary = 1000;
            var tax = Taxation.ComputeTax(vishwas);
            Console.WriteLine($"Total Tax Applicable For {vishwas.Name} is {tax}");
            Console.ReadLine();
        }
    }
}
