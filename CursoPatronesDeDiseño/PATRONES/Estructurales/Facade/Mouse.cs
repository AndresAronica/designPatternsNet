namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Facade
{
    public class Mouse : IMouse
    {
        public void Conectar()
        {
            Console.WriteLine($"{nameof(Mouse)} conectado");
        }
    }
}