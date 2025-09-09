namespace Builder
{
    public class HealthyMealBuilder : MealBuilder
    {
        protected override void AddStarter()
        {
            this.meal.Starter = "a few green leaves";
        }

        protected override void AddMain()
        {
            this.meal.MainCourse = "a huge plate of salmon";
        }

        protected override void AddDessert()
        {
            this.meal.SetDessert("fruit and berries");
        }

        protected override void AddToppings()
        {
            this.meal.AddTopping("fresh herbs");
        }
    }
}
