namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Adapter
{
    /// <summary>
    /// Implementacion de <b>Adapter.</b> <br></br>
    /// Convierte la interfaz de una clase en otra interfaz, que el cliente espera. <br></br>
    /// El adaptador funciona como puente entre el cliente (que usa IConexionSQL) y la interfaz IConexionNoSQL.
    /// </summary>
    public class AdaptadorDB : IConexionSQL
    {
        // Lo uso para conectar entre si las interfaces que de por si no pueden trabajar en conjunto
        private IConexionNoSQL NoSQL;

        /// <summary>
        /// Se usa el constructor para pasarle una instancia de IConexionNoSQL
        /// </summary>
        /// <param name="noSQL"></param>
        public AdaptadorDB(IConexionNoSQL noSQL) => NoSQL = noSQL;

        /// <summary>
        /// Cada metodo de AdaptadorDB (IConexionSQL) va a llamar a su equivalente de IConexionNoSQL
        /// </summary>
        public void Conexion() => NoSQL.Conexion();

        /// <summary>
        /// Cada metodo de AdaptadorDB (IConexionSQL) va a llamar a su equivalente de IConexionNoSQL
        /// </summary>
        public string RunQuery() => NoSQL.ExecuteSentence();
    }
}
