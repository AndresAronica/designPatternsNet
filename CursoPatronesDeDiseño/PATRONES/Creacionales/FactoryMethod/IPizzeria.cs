namespace CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod
{
    /// <summary>
    /// Implementacion de <b>FACTORY METHOD</b> <br></br>
    /// Define una interfaz para la creacion de un objeto, pero deja que la subclase decida que clase instanciar
    /// </summary>
    public interface IPizzeria
    {
        Pizza CrearPizza(string tipo);
    }
}
