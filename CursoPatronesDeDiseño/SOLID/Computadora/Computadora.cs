namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Facade
{
    public class Computadora
    {
        // Con esto
        private ITeclado Teclado;
        private IMouse Mouse;

        // Y esto se implementa SOLID Inversion de Dependencias
        // Ademas, se cumple con Open/Closed (Acepta cualquier tipo de Teclado/Mouse)
        public Computadora(ITeclado teclado, IMouse mouse)
        {
            Teclado = teclado;
            Mouse = mouse;
        }

        public void Encender()
        {
            Teclado.Conectar();
            Mouse.Conectar();
        }
    }
}
