namespace Bank_accounts
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, Balance balance, InterestRate interestRate)
            : base(customer, balance, interestRate)
        {

        }
        public void Deposit(decimal value)
        {
            this.balance.BalanceAmount += value;

        }

        public void Withdraw(decimal value)
        {
            this.balance.BalanceAmount -= value;

        }
        protected override decimal CalculateInterestRate(int numOfMonths, decimal interestRate)
        {
            if (this.balance.BalanceAmount > 0 && this.balance.BalanceAmount < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestRate(numOfMonths, interestRate);
            }
        }
    }
}
