namespace CursoPatronesDeDiseño.SOLID.FigurasGeometricas
{
    public class Triangulo : IFiguraGeometrica
    {
        public float Base { get; set; }
        public float Altura { get; set; }

        public Triangulo(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public override string ToString() => $"Base {Base} Altura {Altura}";

        public float Area() => Base * Altura / 2;
    }
}
