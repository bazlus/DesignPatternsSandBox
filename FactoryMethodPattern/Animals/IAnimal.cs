using System;

namespace FactoryMethodPattern.Animals
{
    public abstract class Animal
    {
        private readonly string _name;

        protected Animal(string name)
        {
            _name = name;
        }

        public void Introduce()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and my name is {this._name}");
        }
    }
}
