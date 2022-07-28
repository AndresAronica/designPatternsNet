namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Mediator
{
    public class Usuario
    {
        public string Nombre { get; }

        public Usuario(string nombre) => Nombre = nombre;

        public void RecibirMensaje(string mensaje) => Console.WriteLine(mensaje);
    }
}
