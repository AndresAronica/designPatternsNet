namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Observer
{
    /// <summary>
    /// Interfaz implementada por los objetos que estan interesados en el cambio (Observers).
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Una implementacion un poco generica. Podria tener diferentes metodos para cada accion a observar, que seria lo ideal en otros casos.
        /// </summary>
        /// <param name="mensaje"></param>
        void Notificacion(string mensaje);
    }
}
