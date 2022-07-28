namespace CursoPatronesDeDiseño.SOLID.FigurasGeometricas
{
    /// <summary>
    /// Su aporte a SOLID Single Responsibility es que se encargan de definir QUE mostrar, pero no COMO mostrarlo.
    /// </summary>
    public class Rectangulo : IFiguraGeometrica
    {
        public float Base { get; set; }
        public float Altura { get; set; }

        public Rectangulo(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override string ToString() => $"Base {Base} Altura {Altura}";

        public float Area() => Base * Altura;
    }
}
