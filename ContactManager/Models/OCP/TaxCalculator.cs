namespace ContactManager.Models.OCP
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator obj)
        {
            decimal taxAmount = obj.CalculateTaxAmount();
            // do something more if needed

            return taxAmount;
        }
    }
}
