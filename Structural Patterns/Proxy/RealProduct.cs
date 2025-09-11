namespace Proxy
{
    public class RealProduct : IProduct
    {
        private readonly string _productNumber;

        public RealProduct(string productNumber) 
        { 
            _productNumber = productNumber;
            Console.WriteLine($"RealProduct: loading heavy data for {_productNumber}"); 
        }

        public string GetDetails() => $"Details for {_productNumber} (heavy)";
    }
}
