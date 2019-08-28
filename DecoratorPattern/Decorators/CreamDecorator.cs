using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorators
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal Cost()
        {
            return base.coffee.Cost() + 0.7m;
        }

        public override string GetDescription()
        {
            return base.coffee.GetDescription() + ", with Cream";
        }
    }
}
