namespace CursoPatronesDeDiseño.PATRONES.Creacionales.AbstractFactory
{
    /// <summary>
    /// Implementacion de <b>Abstract Factory</b> <br></br>
    /// Provee una interfaz para la creacion de familias de objetos, sin especificar una clase en concreto. Especificar la implementacion es trabajo de la Factory en si. <br></br>
    /// Con la interfaz, puedo generar N cantidad de Factories. <br></br>
    /// Como los metodos devuelven una interfaz (y no un objeto), me permite la flexibilidad de generar cualquier tipo de objeto que implemente IComputadora/ITablet <br></br>
    /// </summary>
    public interface IAbstractFactory
    {
        IComputadora CrearComputadora();

        ITablet CrearTablet();
    }
}
