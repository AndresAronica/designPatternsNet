namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Visitor
{
    /// <summary>
    /// Con esta implementacion, el producto desconoce si se le aplica un descuento o no. <br></br>
    /// El producto tiene un precio fijo, y es la clase DescuentoComun la que se encarga de aplicar los descuentos. <br></br>
    /// En caso de que haya DescuentoVacaciones, DescuentoFiestas, etc, habria mas clases encargadas de eso.
    /// </summary>
    public class DescuentoComun : IVisitor
    {
        public float Visit(IFruta fruta) => fruta.GetPrecio() * 0.1f;

        public float Visit(ILineaBlanca lineaBlanca) => lineaBlanca.GetPrecio() * 0.05f;
    }
}
