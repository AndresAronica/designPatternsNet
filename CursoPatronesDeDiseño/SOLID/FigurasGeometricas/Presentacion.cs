namespace CursoPatronesDeDiseño.SOLID.FigurasGeometricas
{
    /// <summary>
    /// Me sirve para implementar el principio SOLID Single Responsibility
    /// Me aseguro de separar el QUE voy a mostrar, del COMO lo voy a mostrar
    /// La clase Presentacion se encarga de definir el COMO (en este caso, por consola)
    /// </summary>
    public class Presentacion
    {
        public void Area(IFiguraGeometrica figuraGeometrica) => Console.WriteLine(figuraGeometrica.Area());
    }
}
