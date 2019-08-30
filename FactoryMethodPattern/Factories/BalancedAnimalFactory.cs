using System;
using System.Collections.Generic;
using System.Reflection;
using FactoryMethodPattern.Animals;

namespace FactoryMethodPattern.Factories
{
    public class BalancedAnimalFactory : IAnimalFactory
    {
        private Queue<Type> animalTypes;

        public BalancedAnimalFactory()
        {
            animalTypes = new Queue<Type>();
            animalTypes.Enqueue(typeof(Cat));
            animalTypes.Enqueue(typeof(Dog));
            animalTypes.Enqueue(typeof(Duck));
        }

        public Animal GetAnimal(string animalName)
        {
            var currentType = animalTypes.Dequeue();
            animalTypes.Enqueue(currentType);

            return (Animal) Activator.CreateInstance(currentType, animalName);
        }
    }
}
