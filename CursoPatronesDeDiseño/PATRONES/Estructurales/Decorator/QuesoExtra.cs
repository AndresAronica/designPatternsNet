namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Decorator
{
    /// <summary>
    /// Implementacion de <b>Composite.</b> <br></br>
    /// Esta clase puede generar un objeto IPizza con algo extra, en este caso Queso. <br></br>
    /// Usa los metodos base de la pizza que le estoy pasando y les agrega algo mas.
    /// </summary>
    public class QuesoExtra : IPizza
    {
        private IPizza Pizza;

        public QuesoExtra(IPizza pizza) => Pizza = pizza;

        public string Descripcion() => $"{Pizza.Descripcion()} queso extra";

        public float Precio() => Pizza.Precio() + 2;
    }
}
