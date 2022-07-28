namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Flyweight
{
    public class Nube
    {
        public TipoNube TipoNube { get; set; }
        public string Imagen { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        public Nube(TipoNube tipoNube, string imagen, int posicionX, int posicionY)
        {
            TipoNube = tipoNube;
            Imagen = imagen;
            PosicionX = posicionX;
            PosicionY = posicionY;
        }
    }
}
