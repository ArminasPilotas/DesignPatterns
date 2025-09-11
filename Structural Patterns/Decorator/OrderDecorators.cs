namespace Decorator
{
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder _order;

        protected OrderDecorator(IOrder order) { _order = order; }

        public virtual decimal Total() => _order.Total();

        public virtual string Description() => _order.Description();
    }

    public class GiftWrapDecorator : OrderDecorator
    {
        public GiftWrapDecorator(IOrder order) : base(order) { }

        public override decimal Total() => base.Total() + 2.5m;

        public override string Description() => base.Description() + ", Gift wrap";
    }

    public class ExpressDecorator : OrderDecorator
    {
        public ExpressDecorator(IOrder order) : base(order) { }

        public override decimal Total() => base.Total() + 15m;

        public override string Description() => base.Description() + ", Express shipping";
    }
}
