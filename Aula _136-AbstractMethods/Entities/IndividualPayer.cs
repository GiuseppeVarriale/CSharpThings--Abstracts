using System;
using System.Collections.Generic;
using System.Text;

namespace Aula__136_AbstractMethods.Entities
{
    class IndividualPayer : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public IndividualPayer()
        {
        }

        public IndividualPayer(string name, double anualIncome,double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            int taxPercent = AnualIncome < 2000.00 ? 15 : 25;
            double healthCompensation = HealthExpenditures / 2.0;
            double taxesPaid = ((double)taxPercent / 100) * AnualIncome - healthCompensation;
            return taxesPaid;
        }
    }
}
