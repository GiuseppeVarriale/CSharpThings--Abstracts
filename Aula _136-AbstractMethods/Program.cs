using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using Aula__136_AbstractMethods.Entities;

namespace Aula__136_AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                    taxPayers.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees:");
                    int employeesNumber = int.Parse(Console.ReadLine());
                    taxPayers.Add(new CompanyPayer(name, anualIncome, employeesNumber));
                }
            }
           
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0;
            StringBuilder sb = new StringBuilder();
            foreach (TaxPayer taxPayer in taxPayers)
            {
                totalTaxes += taxPayer.TaxesPaid();
                Console.WriteLine($"{taxPayer.Name} $ {taxPayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total Taxes: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}