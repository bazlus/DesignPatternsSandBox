namespace DecoratorPattern.Decorators
{
    public class MilkDecorator : Decorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal Cost()
        {
            return base.coffee.Cost() + 0.5m;
        }

        public override string GetDescription()
        {
            return base.coffee.GetDescription() + ", with Milk";
        }
    }
}
