namespace Prototype
{
    public class Program
    {
        static void Main()
        {
            var baseTesla = new Car { Make = "Tesla", Model = "Model 3", Color = "Gray" };
            Console.WriteLine($"Base object {baseTesla}");

            var redVariantTesla = (Car)baseTesla.Clone();
            redVariantTesla.Color = "Red";
            Console.WriteLine($"Base object cloned with color change {redVariantTesla}");

            var teslaRoadster = (Car)baseTesla.Clone();
            teslaRoadster.Model = "Roadster";
            Console.WriteLine($"Base object cloned with model change {teslaRoadster}");
        }
    }
}
