namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Adapter
{
    public class ConexionMongoDB : IConexionNoSQL
    {
        public void Conexion() => Console.WriteLine("Conexion con MongoDB");

        public string ExecuteSentence() => "Consulta MongoDB";
    }
}
