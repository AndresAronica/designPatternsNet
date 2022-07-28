namespace CursoPatronesDeDiseño.SOLID.Animales
{
    public class Jaguar : Animal, IFelinoSalvaje
    {

        private int Edad { get; set; }
        private int Peso { get; set; }

        public Jaguar()
        {
            Edad = 0;
            Peso = 5;
        }

        public override void Comer() => Console.WriteLine($"{nameof(Jaguar)} esta comiendo");

        public override void Dormir() => Console.WriteLine($"{nameof(Jaguar)} esta durmiendo");

        public void Cazar() => Console.WriteLine("Estoy cazando");

        public void Rugir() => Console.WriteLine("Estoy Rugiendo");
    }
}
