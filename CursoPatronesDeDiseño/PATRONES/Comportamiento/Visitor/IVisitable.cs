namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Visitor
{
    /// <summary>
    ///  Interfaz a implementar por los productos que van a tener un descuento
    /// </summary>
    public interface IVisitable
    {
        float AplicarDescuento(IVisitor visitor);
    }
}
