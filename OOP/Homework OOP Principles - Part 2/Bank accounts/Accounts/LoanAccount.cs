using System;
namespace Bank_accounts
{
    public class LoanAccount : Account , IDepositable
    {
        public LoanAccount(Customer customer, Balance balance, InterestRate interestRate)
            : base(customer, balance, interestRate)
        {

        }
        public void Deposit(decimal value)
        {
            this.balance.BalanceAmount += value;
        }
        protected override decimal CalculateInterestRate(int numOfMonths, decimal interestRate)
        {
            if (base.customer is IndividualCustomers)
            {
                return (numOfMonths-2) * interestRate;
            }
            else if (base.customer is CompanieCustomers)
            {
                return (numOfMonths-3) * interestRate;
            }
            else
            {
                throw new Exception("Invalid Customer");
            }
        }
    }
}
