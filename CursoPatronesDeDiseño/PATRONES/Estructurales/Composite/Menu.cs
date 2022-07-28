namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Composite
{
    /// <summary>
    /// Implementacion de <b>Composite.</b> <br></br>
    /// Sirve para construir objetos complejos a partir de otros más simples y similares entre sí, gracias a la composición recursiva y a una estructura en forma de árbol. <br></br>
    /// El ejemplo hace referencia a los menus de un programa, que tiene distintos niveles de anidamiento (con estructura de arbol).
    /// </summary>
    public class Menu : IMenu
    {
        private List<IMenu> menus;

        public Menu()
        {
            menus = new List<IMenu>();
        }

        public bool Open()
        {
            Console.WriteLine("Open!");
            return true;
        }

        public bool Close()
        {
            Console.WriteLine("Close!");
            return false;
        }

        public void AddMenu(IMenu menu) => menus.Add(menu);

        public IMenu GetMenu(int pos) => menus[pos];
    }
}
