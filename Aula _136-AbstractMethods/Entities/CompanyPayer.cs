using System;
using System.Collections.Generic;
using System.Text;

namespace Aula__136_AbstractMethods.Entities
{
    class CompanyPayer : TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public CompanyPayer()
        {
        }

        public CompanyPayer(string name, double anualIncome,int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override string TaxesPaid()
        {
            int taxPercent = EmployeesNumber > 10 ? 14 : 16;
            double taxesPaid = taxPercent / 100 * AnualIncome;
            return $"{Name}: $ {taxesPaid}";
        }
    }
}
