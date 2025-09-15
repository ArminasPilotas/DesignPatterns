namespace Flyweight
{
    public class TeaShop
    {
        private Dictionary<int, Tea> Orders = new Dictionary<int, Tea>();
        private readonly TeaMaker mTeaMaker;

        public TeaShop(TeaMaker teaMaker)
        {
            mTeaMaker = teaMaker ?? throw new ArgumentNullException("teaMaker", "teaMaker cannot be null");
        }

        public void TakeOrder(string teaType, int table)
        {
            Orders[table] = mTeaMaker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var table in Orders.Keys)
            {
                Console.WriteLine($"Serving Tea to table # {table}");
            }
        }
    }
}
