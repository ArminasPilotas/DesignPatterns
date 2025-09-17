namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var androidBuilder = new AndroidBuilder();
            androidBuilder.Build();

            Console.WriteLine();

            var iosBuilder = new IosBuilder();
            iosBuilder.Build();
        }
    }
}
