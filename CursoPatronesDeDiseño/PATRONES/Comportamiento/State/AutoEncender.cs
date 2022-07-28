namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.State
{
    public class AutoEncender : IEstadoAuto
    {
        private readonly Auto Auto;

        public AutoEncender(Auto auto) => Auto = auto;

        // Puedo apagarlo
        public void Apagar()
        {
            Console.WriteLine("El auto esta apagado");
            Auto.EstadoActual = Auto.AutoApagado;
        }

        // No puedo prender el auto si ya esta prendido
        public void Encender() => Console.WriteLine("El auto esta encendido");

        // Puedo manejarlo
        public void Manejar()
        {
            Console.WriteLine("El auto esta en movimiento");
            Auto.EstadoActual = Auto.AutoMovimiento;
        }
    }
}
