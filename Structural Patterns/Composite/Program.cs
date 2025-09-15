namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var developer = new Developer("John", 5000);
            var designer = new Designer("Arya", 5000);

            var organization = new Organisation();
            organization.AddEmployee(developer);
            organization.AddEmployee(designer);

            Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries()}");
        }
    }
}
