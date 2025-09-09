namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealBuilder builder = new HealthyMealBuilder();
            Meal meal = builder.BuildMeal();
            meal.ServeMeal();

            Console.WriteLine("");

            builder = new NutrientMealBuilder();
            meal = builder.BuildMeal();
            meal.ServeMeal();
        }
    }
}
