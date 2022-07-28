namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Adapter
{
    public interface IConexionNoSQL
    {
        void Conexion();
        string ExecuteSentence();
    }
}
