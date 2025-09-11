namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct product = new ProductProxy("some product number.");
            Console.WriteLine("Proxy created, real not loaded yet");
            Console.WriteLine(product.GetDetails());
        }
    }
}
