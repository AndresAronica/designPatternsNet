namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Strategy
{
    /// <summary>
    /// Clase que encapsula todos los algoritmos en un contexto
    /// </summary>
    public class Transaccion
    {
        private IEstrategia Estrategia; // Algoritmo

        public Transaccion(IEstrategia estrategia) => Estrategia = estrategia;

        /// <summary>
        /// Se encarga de ejecutar el algoritmo. <br></br>
        /// No le interesa cual, solamente le interesa ejecutar el algoritmo que se encuentra encapsulado en su propia clase.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public float EjecutarTransaccion(float balance, float cantidad) => Estrategia.RealizarOperacion(balance, cantidad);
    }
}
