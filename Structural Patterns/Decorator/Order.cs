namespace Decorator
{
    public class Order : IOrder
    {
        public decimal BaseAmount { get; init; }

        public Order(decimal amount) => BaseAmount = amount;

        public decimal Total() => BaseAmount;

        public string Description() => "Base order";
    }
}
