namespace CursoPatronesDeDiseño.PATRONES.Creacionales.Prototype
{
    /// <summary>
    /// Implementacion de <b>Prototype.</b> <br></br>
    /// Especifica los tipos de objetos a crear usando una instancia prototipal, y crea nuevos objetos copiando el prototipo. <br></br>
    /// La idea es crear objetos parecidos unos a otros, no necesariamente iguales. <br></br>
    /// Conviene usarlo cuando los atributos son costosos de obtener (llamada a DB, API, FileSystem, etc.).
    /// </summary>
    public class Enemigo
    {
        public string Imagen { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int CantidadVida { get; set; }

        public Enemigo(string imagen, int posicionX, int posicionY, int cantidadVida)
        {
            Imagen = imagen;
            PosicionX = posicionX;
            PosicionY = posicionY;
            CantidadVida = cantidadVida;
        }

        /// <summary>
        /// Primera forma de implementar Prototype. <br></br>
        /// Recibe un objeto de su mismo tipo, y le asigna a las propiedades los valores del objeto que recibe. <br></br>
        /// Esta haciendo una copia exacta del objeto anterior.
        /// </summary>
        /// <param name="enemigo"></param>
        public Enemigo(Enemigo enemigo)
        {
            Imagen = enemigo.Imagen;
            PosicionX = enemigo.PosicionX;
            PosicionY = enemigo.PosicionY;
            CantidadVida = enemigo.CantidadVida;
        }

        /// <summary>
        /// Segunda forma de implementar Prototype. <br></br>
        /// Devuelvo un nuevo objeto Enemigo, usando el constructor que usa un objeto Enemigo. <br></br>
        /// Es el prototipo quien se clona a si mismo.
        /// </summary>
        /// <returns></returns>
        public Enemigo Clone() => new(this);
        // Se podria hacer asi, y estaria usando el primer constructor.
        // Supongo que podria servir si no quiero clonar TODAS las propiedades
        // return new Enemigo(this.prop1, this.prop2...)
    }
}
