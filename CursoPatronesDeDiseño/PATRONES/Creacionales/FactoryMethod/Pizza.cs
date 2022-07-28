namespace CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod
{
    public class Pizza
    {
        private int CantidadRebanadas;
        private string Especialidad;

        public Pizza(int cantidadRebanadas, string especialidad)
        {
            CantidadRebanadas = cantidadRebanadas;
            Especialidad = especialidad;
        }

        public override string ToString() => $"Cantidad rebanadas: {CantidadRebanadas} Especialidad: {Especialidad}";
    }
}
