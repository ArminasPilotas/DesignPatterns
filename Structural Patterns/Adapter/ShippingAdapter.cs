namespace Adapter
{
    public class ShippingAdapter : IShippingService
    {
        private OldShippingService _oldShippingService = new();

        public string Ship(string address) => _oldShippingService.CreateShipment(address);
    }
}
