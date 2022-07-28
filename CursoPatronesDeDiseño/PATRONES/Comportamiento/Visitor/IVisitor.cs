namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Visitor
{
    /// <summary>
    /// Implementacion de Visitor <br></br>
    /// Cada linea de producto que pueda tener descuentos va a tener un metodo Visit con la interfaz del producto como argumento
    /// </summary>
    public interface IVisitor
    {
        float Visit(IFruta fruta);
        float Visit(ILineaBlanca lineaBlanca);
    }
}
