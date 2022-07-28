namespace CursoPatronesDeDiseño.PATRONES.Estructurales.VirtualProxy
{
    public class Servicio : IServicio
    {
        public void Actualizar() => Console.WriteLine("Actualizando");

        public void Eliminar() => Console.WriteLine("Eliminando");

        public void Escribir() => Console.WriteLine("Escribiendo");

        public void Leer() => Console.WriteLine("Leyendo");
    }
}
