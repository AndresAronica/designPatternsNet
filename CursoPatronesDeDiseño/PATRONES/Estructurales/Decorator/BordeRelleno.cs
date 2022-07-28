namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Decorator
{
    /// <summary>
    /// Implementacion de <b>Composite.</b> <br></br>
    /// Esta clase puede generar un objeto IPizza con algo extra, en este caso Borde relleno. <br></br>
    /// Usa los metodos base de la pizza que le estoy pasando y les agrega algo mas.
    /// </summary>
    public class BordeRelleno : IPizza
    {
        private IPizza Pizza;

        public BordeRelleno(IPizza pizza) => Pizza = pizza;

        public string Descripcion() => $"{Pizza.Descripcion()} borde relleno";

        public float Precio() => Pizza.Precio() + 4;
    }
}
