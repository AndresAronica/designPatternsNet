namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Composite
{
    public interface IMenu
    {
        bool Open();
        bool Close();
        void AddMenu(IMenu menu);
        IMenu GetMenu(int pos);
    }
}