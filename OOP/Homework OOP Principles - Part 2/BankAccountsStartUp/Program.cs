using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_accounts;

namespace BankAccountsStartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new IndividualCustomers();
            Balance balance = new Balance(1000);
            InterestRate rate = new InterestRate(10);

            Account acc = new DepositAccount(customer, balance, rate);
            
            
        }
    }
}
