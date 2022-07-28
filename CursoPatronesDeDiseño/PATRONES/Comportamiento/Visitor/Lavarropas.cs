namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Visitor
{
    public class Lavarropas : ILineaBlanca, IVisitable
    {
        /// <summary>
        /// Metodo que se encarga de aplicar el descuento mediante la interfaz IVisitor.
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public float AplicarDescuento(IVisitor visitor) => visitor.Visit(this);

        public float GetPrecio() => 200f;
    }
}
