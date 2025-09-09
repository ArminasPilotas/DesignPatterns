namespace Prototype
{
    public class Car : ICarPrototype
    {
        public required string Model { get; set; }

        public required string Make { get; set; }

        public required string Color { get; set; }

        public object Clone() => MemberwiseClone();

        public override string ToString() => $"Car Make: {Make} Model: {Model} Color: {Color}";
    }
}
