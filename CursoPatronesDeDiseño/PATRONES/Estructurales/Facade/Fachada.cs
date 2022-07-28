namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Facade
{
    /// <summary>
    /// Implementacion de <b>Facade.</b> <br></br>
    /// Nos permite utilizar módulos complejos de una forma sencilla y con bajos costos para el cliente. <br></br>
    /// Esta clase se encarga de realizar las tareas complejas del subsistema Computadora y solo le expone al cliente los metodos que le interesan.
    /// </summary>
    public class Fachada
    {
        private Computadora Computadora;

        /// <summary>
        /// El constructor se encarga de crear la computadora y todo lo que necesita para ser creada
        /// </summary>
        public Fachada()
        {
            ITeclado teclado = new Teclado();
            IMouse mouse = new Mouse();

            Computadora = new Computadora(teclado, mouse);
        }

        /// <summary>
        /// Los metodos de instancia se encargan de la parte compleja (configuraciones, DB, API, etc.) <br></br>
        /// La idea es que Encender() se llame asi nomas, mientras que Computadora.Encender() tiene toda la logica compleja que le escondemos al cliente, para que no tenga que preocuparse en pensar esa parte que no le corresponde.
        /// </summary>
        public void Encender() => Computadora.Encender();
    }
}
