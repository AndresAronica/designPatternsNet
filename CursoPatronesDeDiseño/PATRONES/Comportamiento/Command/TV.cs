namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Command
{
    public class TV : IDevice
    {
        private bool _on;

        public TV() => _on = false;

        public void Off()
        {
            _on = false;
            Console.WriteLine("TV Apagada");
        }

        public void On()
        {
            _on = true;
            Console.WriteLine("TV Encendida");
        }
    }
}
