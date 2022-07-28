namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Facade
{
    public class Teclado : ITeclado
    {
        public void Conectar()
        {
            Console.WriteLine($"{nameof(Teclado)} conectado");
        }
    }
}