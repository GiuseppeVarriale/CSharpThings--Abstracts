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

        public override string TaxesPaid()
        {
            int taxPercent = AnualIncome < 2000.00 ? 15 : 25;
            double healthCompensation = HealthExpenditures / 2;
            double taxesPaid = taxPercent / 100 * AnualIncome - healthCompensation;
            return $"{Name}: $ {taxesPaid}";
        }
    }
}
