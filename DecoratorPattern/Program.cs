using System;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        // Simulating a coffee shop where you could combine different ingredients at runtime

        static void Main(string[] args)
        {
            var coffee = new DecafCoffee();

            Console.WriteLine(coffee.Cost());
            Console.WriteLine(coffee.GetDescription());

            ICoffee decoratedCoffee = new MilkDecorator(coffee);

            Console.WriteLine(decoratedCoffee.Cost());
            Console.WriteLine(decoratedCoffee.GetDescription());

            decoratedCoffee = new CreamDecorator(decoratedCoffee);

            Console.WriteLine(decoratedCoffee.Cost());
            Console.WriteLine(decoratedCoffee.GetDescription());
        }
    }
}
