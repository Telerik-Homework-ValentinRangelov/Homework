namespace Bank_accounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, Balance balance, InterestRate interestRate)
            : base(customer, balance, interestRate)
        {

        }
        public void Deposit(decimal value)
        {
            this.balance.BalanceAmount += value;

        }
        protected override decimal CalculateInterestRate(int numOfMonths, decimal interestRate)
        {
            if (base.customer is CompanieCustomers)
            {
                return ((numOfMonths - 12) * interestRate) + ((12 * interestRate) / 2);
            }
            else
            {
                return (numOfMonths - 6) * interestRate;
            }
        }
    }
}
