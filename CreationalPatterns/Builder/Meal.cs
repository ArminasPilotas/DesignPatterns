namespace Builder
{
    public class Meal
    {
        public string Starter { get; set; }

        public string MainCourse { get; set; }

        public Dessert Dessert { get; set; }

        public void SetDessert(string dessertName) => this.Dessert = new Dessert(dessertName);

        public void AddTopping(string topping) => this.Dessert.AddTopping(topping);

        public void ServeMeal()
        {
            Console.WriteLine($"Bringing you {Starter}, " +
                $"then {MainCourse}, " +
                $"then {Dessert.Name} with {Dessert.ListToppings()} on top");
        }
    }
}
