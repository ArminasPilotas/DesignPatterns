namespace FactoryMethod
{
    public record Order
    {
        public required int Id { get; init; }

        public required decimal Amount { get; init; }

        public override string ToString() => $"Order #{Id} (${Amount})";
    }
}
