namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Adapter
{
    public class ConexionMySQL : IConexionSQL
    {
        public void Conexion() => Console.WriteLine("Conexion con MySQL");
        public string RunQuery() => "Consulta MySQL";
    }
}
