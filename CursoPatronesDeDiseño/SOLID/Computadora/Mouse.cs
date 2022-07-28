namespace CursoPatronesDeDiseño.SOLID.Computadora
{
    public class Mouse : IMouse
    {
        public void Conectar()
        {
            Console.WriteLine($"{nameof(Mouse)} conectado");
        }
    }
}