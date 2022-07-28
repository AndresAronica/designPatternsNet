namespace CursoPatronesDeDiseño.SOLID.FigurasGeometricas
{
    /// <summary>
    /// Me sirve para implementar el principio SOLID Open/Closed
    /// Me aseguro de que puedo agregar N cantidad nueva de figuras y lo unico que tienen que hacer para mostrar su area es implementar esta interfaz
    /// </summary>
    public interface IFiguraGeometrica
    {
        float Area();
    }
}
