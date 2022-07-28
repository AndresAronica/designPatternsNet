namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Command
{
    /// <summary>
    /// Para desacoplar los metodos, se genera una clase por cada metodo. <br></br>
    /// La clase Tv tenia un metodo On un metodo Off, que salen a una clase cada uno.
    /// </summary>
    public class OffDevice : ICommand
    {
        private IDevice _device;

        public OffDevice(IDevice device) => _device = device;

        /// <summary>
        /// Implementa el metodo puntual para el cual fue creada la clase
        /// </summary>
        public void Operacion() => _device.Off();
    }
}
