using System;
using System.Collections.Generic;
using System.Text;

namespace Aula__136_AbstractMethods.Entities
{
    class IndividualPayer : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public override string PayTaxes()
        {
            throw new NotImplementedException();
        }
    }
}
