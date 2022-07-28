namespace CursoPatronesDeDiseño.PATRONES.Creacionales.SimpleFactory
{
    public class Pizza
    {
        private int CantidadRebanadas;

        public Pizza(int cantidadRebanadas) => CantidadRebanadas = cantidadRebanadas;

        public override string ToString() => $"Cantidad rebanadas: {CantidadRebanadas}";
    }
}
