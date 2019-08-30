using System;
using FactoryMethodPattern.Factories;

namespace FactoryMethodPattern
{
    class Program
    {
        //Simulating creating animals of different types and different logic
        static void Main(string[] args)
        {
            IAnimalFactory randomAnimalFactory = new RandomAnimalFactory();

            var randomAnimal = randomAnimalFactory.GetAnimal("Max");
            var randomAnimal2 = randomAnimalFactory.GetAnimal("Jack");
            var randomAnimal3 = randomAnimalFactory.GetAnimal("Rick");

            randomAnimal.Introduce();
            randomAnimal2.Introduce();
            randomAnimal3.Introduce();

            // Another factory

            IAnimalFactory balancedAnimalFactory = new BalancedAnimalFactory();

            var animal = balancedAnimalFactory.GetAnimal("Max");
            var animal2 = balancedAnimalFactory.GetAnimal("Jack");
            var animal3 = balancedAnimalFactory.GetAnimal("Rick");

            animal.Introduce();
            animal2.Introduce();
            animal3.Introduce();
        }
    }
}
