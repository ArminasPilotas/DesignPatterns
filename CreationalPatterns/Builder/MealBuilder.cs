namespace Builder
{
    public abstract class MealBuilder
    {
        protected Meal meal = new();

        public Meal BuildMeal()
        {
            AddStarter();
            AddMain();
            AddDessert();
            AddToppings();

            return meal;
        }

        protected abstract void AddStarter();

        protected abstract void AddMain();

        protected abstract void AddDessert();

        protected abstract void AddToppings();
    }
}
