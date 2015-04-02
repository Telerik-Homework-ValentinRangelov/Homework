namespace Bank_accounts
{
    public abstract class Account
    {
        protected Customer customer;
        protected Balance balance;
        protected InterestRate interestRate;
        
        public Account(Customer customer,Balance balance,InterestRate interestRate)
        {

            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }
        protected virtual decimal CalculateInterestRate(int numOfMonths, decimal interestRate)
        {
            return numOfMonths * interestRate;
        }
        
    }
}
