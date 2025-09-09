namespace Builder
{
    public class Dessert
    {
        public string Name { get; set; }
        private readonly IList<string> toppings = [];

        public Dessert(string dessertName)
        {
            Name = dessertName;
        }

        public void AddTopping(string topping) => toppings.Add(topping);

        public string ListToppings()
        {
            string result = "Toppings: ";
            foreach (var topping in toppings)
            {
                result += $"{topping} ";
            }

            return result;
        }
    }
}
