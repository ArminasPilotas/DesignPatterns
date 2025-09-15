namespace Composite
{
    public class Organisation
    {
        public List<IEmployee> employees;

        public Organisation()
        {
            employees = [];
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;

            foreach (var e in employees)
            {
                netSalary += e.GetSalary();
            }
            return netSalary;
        }
    }
}
