namespace ChainOfResponsibility
{
    public abstract class Account
    {
        private Account Successor;
        protected decimal Balance;

        public void SetNext(Account account)
        {
            Successor = account;
        }

        public void Pay(decimal amountTopay)
        {
            if (CanPay(amountTopay))
            {
                Console.WriteLine($"Paid {amountTopay}$ using {this.GetType().Name}.");
            }
            else if (this.Successor != null)
            {
                Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding..");
                Successor.Pay(amountTopay);
            }
            else
            {
                throw new Exception("None of the accounts have enough balance");
            }
        }
        private bool CanPay(decimal amount)
        {
            return Balance >= amount;
        }
    }
}
