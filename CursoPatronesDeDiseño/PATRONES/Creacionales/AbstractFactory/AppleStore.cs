namespace CursoPatronesDeDiseño.PATRONES.Creacionales.AbstractFactory
{
    /// <summary>
    /// En este caso, AppleStore es una implementacion especifica de la Abstract Factory, encargada de devolver los tipos especificos para los metodos de la Interfaz.
    /// </summary>
    public class AppleStore : IAbstractFactory
    {
        public IComputadora CrearComputadora() => new MackbookPro();

        public ITablet CrearTablet() => new IPad();
    }
}
