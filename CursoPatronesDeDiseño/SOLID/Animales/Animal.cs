namespace CursoPatronesDeDiseño.SOLID.Animales
{
    public class Animal
    {
        public virtual void Comer() => Console.WriteLine($"{nameof(Animal)} esta comiendo");

        public virtual void Dormir() => Console.WriteLine($"{nameof(Animal)} esta durmiendo");
    }
}
