namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var computer = new ComputerFacade(new Computer());
            computer.TurnOn();
            Console.WriteLine();
            computer.TurnOff();
            Console.ReadLine();
        }
    }
}
