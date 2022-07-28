namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Command
{
    /// <summary>
    /// Interfaz que implementa el Patron Command. <br></br>
    /// La interfaz debe tener solamente un metodo (puede llamarse Operacion).
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Es el que va a ser llamado por las clases especificas que implementan un metodo cada una.
        /// </summary>
        void Operacion();
    }
}
