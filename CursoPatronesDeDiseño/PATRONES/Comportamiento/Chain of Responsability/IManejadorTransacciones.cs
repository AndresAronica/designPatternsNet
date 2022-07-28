namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Chain_Of_Responsability
{
    /// <summary>
    /// Implementacion de Chain of Responsability <br></br>
    /// En este caso, el orden de la cadena va a ser Deposito -> Retiro -> Reembolso
    /// </summary>
    public interface IManejadorTransacciones
    {
        /// <summary>
        /// Metodo que me permite encadenar objetos. <br></br>
        /// Permite apuntar al siguiente objeto en caso de que el objeto actual no pueda responder satisfactoriamente a la peticion.
        /// </summary>
        /// <param name="next"></param>
        void SetNextManejador(IManejadorTransacciones next);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transaccion">Por simplicidad esta recibiendo como parametro una implementacion, pero por principios SOLID lo correcto seria que reciba una Interfaz.</param>
        void EjecutarTransaccion(Transaccion transaccion);
    }
}
