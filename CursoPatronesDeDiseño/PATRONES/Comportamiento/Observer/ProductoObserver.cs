namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Observer
{
    public class ProductoObserver : IObservable
    {
        public int Stock { get; set; }
        /// <summary>
        /// Lo uso para guardar los observadores. En este caso con un Set, para que sean unicos. <br></br>
        /// </summary>
        private HashSet<IObserver> _observers;

        public ProductoObserver(int stock)
        {
            Stock = stock;
            _observers = new HashSet<IObserver>();
        }

        public void Venta()
        {
            Stock--;
            Console.WriteLine("Producto vendido");
            NotificarObservadores("Producto vendido");
        }

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void NotificarObservadores(string mensaje)
        {
            foreach (IObserver observer in _observers)
                observer.Notificacion(mensaje);
        }

        public void QuitarObserver(IObserver observer) => _observers.Remove(observer);
    }
}
