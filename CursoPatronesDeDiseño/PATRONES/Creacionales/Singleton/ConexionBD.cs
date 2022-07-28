namespace CursoPatronesDeDiseño.PATRONES.Creacionales.Singleton
{
    /// <summary>
    /// Implementacion de <b>Singleton</b> <br></br>
    /// Solo puede haber una instancia de la clase. Cuando la llamo, me devuelve siempre la misma instancia si ya se creo, o la crea si no existe. <br></br>
    /// Para eso usa un constructor privado con una propiedad privada del tipo de la clase, y un metodo estatico publico que hace el return.
    /// </summary>
    public class ConexionBD
    {
        private static ConexionBD conexionSingleton;

        private ConexionBD()
        {
        }

        // Para hacerlo concurrente en Java se usa la keyword synchronize
        // TODO Ver como se hace el equivalente en .NET
        public static ConexionBD ObtenerConexion()
        {
            if (conexionSingleton is null) conexionSingleton = new();

            return conexionSingleton;
        }
    }
}
