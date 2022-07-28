namespace CursoPatronesDeDiseño.SOLID.Computadora
{
    public class Teclado : ITeclado
    {
        public void Conectar()
        {
            Console.WriteLine($"{nameof(Teclado)} conectado");
        }
    }
}