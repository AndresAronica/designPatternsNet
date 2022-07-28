namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Memento
{
    /// <summary>
    ///  Implementacion de Memento. <br></br>
    ///  Memento puede implementar una interfaz similar a IMemento, o IRestaurable, o que se yo, algo asi. <br></br>
    ///  Pero no es obligatorio, lo unico que necesita son los metodos para generar la copia de seguridad y restaurarla.
    /// </summary>
    public class UsuarioMemento
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public UsuarioMemento(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        /// <summary>
        /// Devuelve una copia de seguridad del objeto (puede ser total o parcial) <br></br>
        /// En este caso, la copia es total.
        /// </summary>
        /// <returns></returns>
        public UsuarioMemento GetMemento() => new(Nombre, Edad);

        /// <summary>
        /// Restauro el objeto a su estado previo.
        /// </summary>
        /// <param name="usuario">El memento al que lo quiero volver</param>
        public void RestartMemento(UsuarioMemento usuario)
        {
            Nombre = usuario.Nombre;
            Edad = usuario.Edad;
        }

        public override string ToString() => $"Nombre: {Nombre} \r\n Edad: {Edad}";
    }
}
