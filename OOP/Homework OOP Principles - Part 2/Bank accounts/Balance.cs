namespace Bank_accounts
{
    public class Balance
    {
        public decimal BalanceAmount { get; set; }
        public Balance(decimal value)
        {
            this.BalanceAmount = value;
        }
    }
}
