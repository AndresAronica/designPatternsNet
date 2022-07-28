namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Iterator
{
    /// <summary>
    /// .NET ya tiene una interfaz para iterar. <br></br>
    /// La implementacion propia es solo para entender como funciona por detras.
    /// </summary>
    public interface IIterador
    {
        string Siguiente();

        bool ContieneSiguiente();
    }
}
