namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShippingService shippingService = new ShippingAdapter();
            var id = shippingService.Ship("Amsterdam, Netherlands");
            Console.WriteLine($"Shipment created: {id}");
        }
    }
}
