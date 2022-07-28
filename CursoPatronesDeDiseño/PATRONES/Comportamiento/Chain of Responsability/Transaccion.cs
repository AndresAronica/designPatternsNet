namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_Of_Responsability
{
    public class Transaccion
    {
        public float Cantidad { get; set; }
        public float Balance { get; set; }
        public TipoTransaccion TipoTransaccion { get; set; }

        public Transaccion(float cantidad, float balance, TipoTransaccion tipoTransaccion)
        {
            Cantidad = cantidad;
            Balance = balance;
            TipoTransaccion = tipoTransaccion;
        }
    }
}
