namespace CursoPatronesDeDiseño.PATRONES.Estructurales.VirtualProxy
{
    public class Usuario
    {
        public int NivelPermiso { get; set; } // 1 al 5. 5 es Admin

        public Usuario(int nivelPermiso) => NivelPermiso = nivelPermiso;
    }
}
