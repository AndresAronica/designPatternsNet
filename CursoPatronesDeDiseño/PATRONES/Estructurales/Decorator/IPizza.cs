namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Decorator
{
    /// <summary>
    /// Tipo padre para todas las pizzas <br></br>
    /// Haciendolo de esta forma, puedo generar una Pizza Peperoni y combinarla con Queso Extra, o Hawaiana con Borde Relleno, o cualquier tipo de combinacion.
    /// </summary>
    public interface IPizza
    {
        string Descripcion();
        float Precio();
    }
}