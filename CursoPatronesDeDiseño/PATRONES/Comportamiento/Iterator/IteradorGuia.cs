namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Iterator
{
    public class IteradorGuia : IIterador
    {
        private GuiaTelefonica _guiaTelefonica;
        private int _posicion;

        public IteradorGuia(GuiaTelefonica guiaTelefonica) => _guiaTelefonica = guiaTelefonica;

        public bool ContieneSiguiente() => _posicion < _guiaTelefonica.GetNumeros().Count() && _guiaTelefonica.GetNumeros().ElementAt(_posicion) is not null;

        public string Siguiente() => _guiaTelefonica.GetNumeros().ElementAt(_posicion++);
    }
}
