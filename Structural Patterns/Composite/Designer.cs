namespace Composite
{
    public class Designer : IEmployee
    {
        private string Name;
        private float Salary;

        public Designer(string name, float salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public float GetSalary()
        {
            return this.Salary;
        }

        public string GetRole()
        {
            return "Designer";
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
