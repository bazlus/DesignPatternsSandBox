using FactoryMethodPattern.Animals;

namespace FactoryMethodPattern.Factories
{
    public interface IAnimalFactory
    {
        Animal GetAnimal(string animalName);
    }
}
