namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Template_Method
{
    /// <summary>
    /// Implementacion de Template Method <br></br>
    /// Va a tener metodos que todos los hijos comparten, por ser comportamiento comun <br></br>
    /// Ademas, va a tener clases que cada hijo tendra que implementar su propia logica
    /// </summary>
    public abstract class Usuario
    {
        /// <summary>
        /// Metodo generico para todos los usuarios
        /// </summary>
        public void Autenticacion() => Console.WriteLine("Todos los usuarios necesitan autenticarse");

        /// <summary>
        /// Metodo especifico de cada clase hija
        /// </summary>
        public abstract void FormaTrabajar();
    }
}
