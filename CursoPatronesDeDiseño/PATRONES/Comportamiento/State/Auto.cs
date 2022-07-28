namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.State
{
    public class Auto : IEstadoAuto
    {
        // Se crea un atributo por cada estado posible, mas uno extra para el estado actual
        public IEstadoAuto AutoEncendido { get; set; }
        public IEstadoAuto AutoMovimiento { get; set; }
        public IEstadoAuto AutoApagado { get; set; }
        public IEstadoAuto EstadoActual { get; set; }

        public Auto()
        {
            AutoEncendido = new AutoEncender(this);
            AutoMovimiento = new AutoManejar(this);
            AutoApagado = new AutoApagar(this);

            EstadoActual = AutoApagado;
        }

        public void Apagar() => EstadoActual.Apagar();

        public void Encender() => EstadoActual.Encender();

        public void Manejar() => EstadoActual.Manejar();
    }
}
