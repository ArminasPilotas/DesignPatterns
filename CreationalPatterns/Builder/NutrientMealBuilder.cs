using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class NutrientMealBuilder : MealBuilder
    {
        protected override void AddStarter()
        {
            this.meal.Starter = "mixed greens salad with cherry tomatoes";
        }

        protected override void AddMain()
        {
            this.meal.MainCourse = "grilled salmon";
        }

        protected override void AddDessert()
        {
            this.meal.SetDessert("greek yogurt");
        }

        protected override void AddToppings()
        {
            this.meal.AddTopping("chia seeds");
            this.meal.AddTopping("chopped almonds");
        }
    }
}
