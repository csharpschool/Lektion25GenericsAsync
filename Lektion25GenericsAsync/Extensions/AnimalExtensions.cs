using System.ComponentModel;

namespace Lektion25GenericsAsync.Extensions;

public static class AnimalExtensions
{
    public static void AddNew<T>(this List<T> animals, T animal)
        where T : class//, IAnimal
    {
        animals.Add(animal);
    }
}
