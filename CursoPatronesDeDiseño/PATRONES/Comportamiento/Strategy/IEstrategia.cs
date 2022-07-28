namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Strategy
{
    /// <summary>
    /// Implementacion del patron Strategy. <br></br>
    /// La interfaz define el metodo que va a implementar las diferentes variantes del algoritmo
    /// </summary>
    public interface IEstrategia
    {
        float RealizarOperacion(float balance, float cantidad);
    }
}
