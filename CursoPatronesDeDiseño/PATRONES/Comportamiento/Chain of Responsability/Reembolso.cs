using CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_Of_Responsability;

namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_of_Responsability
{
    public class Reembolso : IManejadorTransacciones
    {
        private IManejadorTransacciones Next;

        /// <summary>
        /// Metodo que va a verificar si puede responder a la transaccion solicitada. <br></br>
        /// En caso de poder, se encarga de responder. <br></br>
        /// En caso de no poder, sale de la cadena ya que es el ultimo eslabon.
        /// </summary>
        /// <param name="transaccion"></param>
        public void EjecutarTransaccion(Transaccion transaccion)
        {
            // Si puedo procesarla, lo hago
            if (transaccion.TipoTransaccion == TipoTransaccion.Reembolso)
            {
                transaccion.Balance += transaccion.Cantidad;
                Console.WriteLine($"El nuevo balance despues del reembolso es {transaccion.Balance}");
            }
            // Si no puedo, ya que es el ultimo elemento de la cadena, en este caso simplemente logueo que no pudo procesarlo.
            else
            {
                Console.WriteLine("Operacion invalida");
            }
        }

        public void SetNextManejador(IManejadorTransacciones next) => Next = next;
    }
}
