namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Strategy
{
    /// <summary>
    /// Cada clase que implementa IEstrategia define una variante del algoritmo
    /// </summary>
    public class Retiro : IEstrategia
    {
        public float RealizarOperacion(float balance, float cantidad) => balance - cantidad;
    }
}
