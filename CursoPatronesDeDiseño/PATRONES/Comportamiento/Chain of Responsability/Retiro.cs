using CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_Of_Responsability;

namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_of_Responsability
{
    public class Retiro : IManejadorTransacciones
    {
        private IManejadorTransacciones Next;

        /// <summary>
        /// Metodo que va a verificar si puede responder a la transaccion solicitada. <br></br>
        /// En caso de poder, se encarga de responder. <br></br>
        /// En caso de no poder, patea la ejecucion a otro objeto.
        /// </summary>
        /// <param name="transaccion"></param>
        public void EjecutarTransaccion(Transaccion transaccion)
        {
            // Si puedo procesarla, lo hago
            if (transaccion.TipoTransaccion == TipoTransaccion.Retiro)
            {
                transaccion.Balance -= transaccion.Cantidad;
                Console.WriteLine($"El nuevo balance despues del retiro es {transaccion.Balance}");
            }
            // Si no puedo, pateo la ejecucion a otro objeto que implemente IManejadorTransacciones
            else
            {
                Next.EjecutarTransaccion(transaccion);
            }
        }

        public void SetNextManejador(IManejadorTransacciones next) => Next = next;
    }
}
