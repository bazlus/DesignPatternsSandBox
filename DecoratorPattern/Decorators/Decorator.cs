namespace DecoratorPattern.Decorators
{
    public abstract class Decorator : ICoffee
    {
        protected readonly ICoffee coffee;

        protected Decorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public abstract decimal Cost();

        public abstract string GetDescription();
    }
}
