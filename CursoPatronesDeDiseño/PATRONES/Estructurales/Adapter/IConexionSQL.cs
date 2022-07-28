namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Adapter
{
    public interface IConexionSQL
    {
        void Conexion();
        string RunQuery();
    }
}
