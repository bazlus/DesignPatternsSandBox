using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using FactoryMethodPattern.Animals;

namespace FactoryMethodPattern.Factories
{
    public class RandomAnimalFactory : IAnimalFactory
    {
        public Animal GetAnimal(string animalName)
        {
            var random = new Random().Next(1, 4);
            Animal animal = null;

            switch (random)
            {
                case 1:
                    animal = new Cat(animalName);
                    break;
                case 2:
                    animal = new Dog(animalName);
                    break;
                case 3:
                    animal = new Duck(animalName);
                    break;
            }

            return animal;
        }
    }
}
