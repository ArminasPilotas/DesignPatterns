namespace Proxy
{
    public class ProductProxy : IProduct
    {
        private readonly string _productNumber;

        private RealProduct? realProduct;
        public ProductProxy(string productNumber) { _productNumber = productNumber; }
        public string GetDetails() 
        {
            realProduct ??= new RealProduct(_productNumber);
            return realProduct.GetDetails(); 
        }
    }
}
