namespace CursoPatronesDeDiseño.PATRONES.Creacionales.SimpleFactory
{
    /// <summary>
    /// Implementacion de <b>SIMPLE FACTORY</b> <br></br>
    /// Formalmente no es considerado un Patron de Diseño <br></br>
    /// TODO Completar descripcion
    /// </summary>
    public class Pizzeria
    {
        // Cada metodo en este caso, al ser un ejemplo simple, solo crea la instancia con la cantidad de porciones especificada
        // En un caso de uso real, podria tener que revisar diferentes archivos en DB, FileSystem, pegarle a una API, lo que sea
        // En ese caso Simple Factory es muy util porque no lo tenes que escribir cada vez que haces una instancia, sino que ya lo tenes todo en el metodo de la Factory
        // Ademas, de esta forma se esconde la logica del cliente, que lo unico que quiere es una pizza de X tamaño, y no le interesa como haces para hacerla
        public Pizza CrearPizzaChica() => new(6);
        public Pizza CrearPizzaMediana() => new(8);
        public Pizza CrearPizzaGrande() => new(12);
    }
}
