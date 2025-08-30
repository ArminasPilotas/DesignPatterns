namespace Singleton
{
    public class Program
    {
        static void Main()
        {
            var cfg = ConfigManager.Instance;
            Console.WriteLine($"PaymentGateway={cfg.Settings["PaymentGateway"]}");
            Console.WriteLine($"Same instance? {object.ReferenceEquals(ConfigManager.Instance, cfg)}");
        }
    }
}
