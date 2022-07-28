namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Observer
{
    /// <summary>
    /// Interfaz implementada por las clases que queremos que notifiquen a los Observers. <br></br>
    /// Quien implementa esta interfaz es la clase que va a ser modificada.
    /// </summary>
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void NotificarObservadores(string mensaje);

        void QuitarObserver(IObserver observer);
    }
}
