namespace Composite
{
    public class Developer : IEmployee
    {
        private string Name;
        private float Salary;

        public Developer(string name, float salary)
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
            return "Developer";
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
