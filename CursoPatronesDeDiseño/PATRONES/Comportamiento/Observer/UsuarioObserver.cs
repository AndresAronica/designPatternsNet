namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Observer
{
    /// <summary>
    /// Objeto que va a ser observador <br></br>
    /// Los observadores pueden ser de cualquier tipo de clase, no solamente de tipo usuario. <br></br>
    /// Para este ejemplo, van a ser solamente usuarios
    /// </summary>
    public class UsuarioObserver : IObserver
    {
        public void Notificacion(string mensaje) => Console.WriteLine($"{mensaje}. Notificacion desde {nameof(UsuarioObserver)}");
    }
}
