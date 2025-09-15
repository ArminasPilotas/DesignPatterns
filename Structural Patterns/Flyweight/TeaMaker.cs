namespace Flyweight
{
    public class TeaMaker
    {
        private Dictionary<string, Tea> AvailableTea = new Dictionary<string, Tea>();

        public Tea Make(string preference)
        {
            if (!AvailableTea.ContainsKey(preference))
            {
                AvailableTea[preference] = new Tea();
            }

            return AvailableTea[preference];
        }
    }
}
