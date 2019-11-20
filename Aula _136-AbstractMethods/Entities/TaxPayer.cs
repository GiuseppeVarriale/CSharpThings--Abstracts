namespace Aula__136_AbstractMethods.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnualIncome { get; private set; }

        public abstract string PayTaxes();

    }
}
