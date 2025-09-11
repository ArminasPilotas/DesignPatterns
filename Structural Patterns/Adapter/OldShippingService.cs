namespace Adapter
{
    // Legacy service we cannot change
    public class OldShippingService
    {
        public string CreateShipment(string address) => $"OLD-SHIPMENT:{address}";
    }
}
