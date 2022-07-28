namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.State
{
    public class AutoManejar : IEstadoAuto
    {
        private readonly Auto Auto;

        public AutoManejar(Auto auto) => Auto = auto;

        // Puedo apagarlo
        public void Apagar()
        {
            Console.WriteLine("El auto esta apagado");
            Auto.EstadoActual = Auto.AutoApagado;
        }

        // No puedo prender el auto si ya esta prendido
        public void Encender() => Console.WriteLine("El auto ya esta encendido");

        // No puedo manejarlo si ya lo estoy manejando
        public void Manejar() => Console.WriteLine("El auto ya esta en movimiento");
    }
}
