namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Decorator
{
    public class PizzaPeperoni : IPizza
    {
        public string Descripcion() => "Pizza de Peperoni";

        public float Precio() => 8;
    }
}
