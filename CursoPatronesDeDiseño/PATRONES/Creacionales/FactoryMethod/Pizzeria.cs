namespace CursoPatronesDeDiseño.PATRONES.Creacionales.FactoryMethod
{
    /// <summary>
    /// Esta es la subclase la que va a decidir que tipo de instancia necesita retornar
    /// </summary>
    public class Pizzeria : IPizzeria
    {
        public Pizza CrearPizza(string tipo)
        {
            // La comprobacion de tipo es para un ejemplo muy simple
            if (tipo.Equals("Peperoni")) return new Pizza(8, tipo);
            if (tipo.Equals("Hawaiana")) return new Pizza(8, tipo);

            if (tipo.Equals("Peperoni borde relleno")) return new PizzaBordeRelleno(12, tipo);
            if (tipo.Equals("Hawaiana borde relleno")) return new PizzaBordeRelleno(12, tipo);

            // Devuelve null para hacer mas facil el ejemplo
            return null;
        }
    }
}
