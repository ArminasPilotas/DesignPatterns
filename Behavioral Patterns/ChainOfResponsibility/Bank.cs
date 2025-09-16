namespace ChainOfResponsibility
{
    public class Bank : Account
    {
        public Bank(decimal balance)
        {
            this.Balance = balance;
        }
    }
}
