namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Flyweight
{
    /// <summary>
    /// Implementacion de <b>Flyweight.</b> <br></br>
    /// Solo genera objetos que no existan en el mapa. <br></br>
    /// De esta forma, puedo dibujar infinita cantidad de nubes de cada tipo, pero en todo momento voy a tener en memoria 1 sola instancia de cada una.
    /// </summary>
    public class NubeFactory
    {
        private Dictionary<TipoNube, Nube> NubesDictionary;

        public NubeFactory() => NubesDictionary = new Dictionary<TipoNube, Nube>();

        /// <summary>
        /// Intenta obtener una nube desde el dictionary. <br></br>
        /// Si no existe, la crea. <br></br>
        /// Si existe, usa esa misma instancia.
        /// </summary>
        /// <param name="tipoNube"></param>
        /// <returns></returns>
        public Nube GetNube(TipoNube tipoNube)
        {
            // Trato de obtener el objeto nube de ese tipo
            Nube? nube = NubesDictionary.GetValueOrDefault(tipoNube);

            // Si no existe, lo creo y lo pongo en el diccionario
            if (nube == null)
            {
                nube = new Nube(tipoNube, $"{tipoNube}.png", 100, 100);
                NubesDictionary.Add(tipoNube, nube);
            }

            return nube;
        }

        /// <summary>
        /// Metodo para demostrar que no importa cuantas veces intente crear cada nube, solo la esta creando una vez y despues devuelve la misma instancia.
        /// </summary>
        /// <returns></returns>
        public int CountNubesDictionary() => NubesDictionary.Count;
    }
}
