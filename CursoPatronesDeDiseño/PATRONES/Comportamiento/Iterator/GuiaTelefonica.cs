namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Iterator
{
    public class GuiaTelefonica
    {
        private List<string> _numeros;

        public GuiaTelefonica() => _numeros = new List<string>();

        public void Add(string numero) => _numeros.Add(numero);

        public List<string> GetNumeros() => _numeros;
    }
}
