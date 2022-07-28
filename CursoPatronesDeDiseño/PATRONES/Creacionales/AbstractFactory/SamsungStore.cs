namespace CursoPatronesDeDiseño.PATRONES.Creacionales.AbstractFactory
{
    /// <summary>
    /// En este caso, SamsungStore es una implementacion especifica de la Abstract Factory, encargada de devolver los tipos especificos para los metodos de la Interfaz.
    /// </summary>
    public class SamsungStore : IAbstractFactory
    {
        public IComputadora CrearComputadora() => new GalaxyBookPro();

        public ITablet CrearTablet() => new GalaxyTab();
    }
}
