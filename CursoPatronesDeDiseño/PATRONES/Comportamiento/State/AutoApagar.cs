namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.State
{
    public class AutoApagar : IEstadoAuto
    {
        private readonly Auto Auto;

        public AutoApagar(Auto auto) => Auto = auto;

        // No puedo apagarlo si esta apagado
        public void Apagar() => Console.WriteLine("El auto esta apagado");

        // Puedo prenderlo si esta apagado
        public void Encender()
        {
            Console.WriteLine("El auto esta encendido");
            Auto.EstadoActual = Auto.AutoEncendido;
        }

        // No puedo manejarlo si esta apagado
        public void Manejar() => Console.WriteLine("El auto no se puede manejar si esta apagado");
    }
}
