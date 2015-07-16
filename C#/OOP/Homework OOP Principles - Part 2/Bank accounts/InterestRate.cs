namespace Bank_accounts
{
    public class InterestRate
    {
        private decimal rateValue;
        public InterestRate(decimal rateValue)
        {
            this.rateValue = rateValue;
        }
        public decimal RateValue
        {
            get
            {
                return rateValue;
            }

        }
    }
}
