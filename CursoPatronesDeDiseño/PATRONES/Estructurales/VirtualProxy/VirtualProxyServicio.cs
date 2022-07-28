namespace CursoPatronesDeDiseño.PATRONES.Estructurales.VirtualProxy
{
    /// <summary>
    /// Implementacion de <b> Virtual Proxy.</b> Su intencion es limitar funcionalidad del sistema.<br></br>
    /// Es una variante de Proxy. No restringe el acceso al objeto, sino que intenta retrasar su creacion. <br></br>
    /// Un motivo de uso puede ser que el objeto a crear tiene un costo muy alto. <br></br>
    /// </summary>
    public class VirtualProxyServicio : IServicio
    {
        private IServicio Servicio; // Asumimos que este es el objeto costoso.
        private Usuario Usuario;

        public VirtualProxyServicio(Usuario usuario) => Usuario = usuario;

        /// <summary>
        /// Por cada instancia de la clase voy a poder tener una sola creacion de Servicio, ya que es costoso de crear.
        /// </summary>
        /// <returns></returns>
        private IServicio ObtenerServicio()
        {
            if (Servicio is null) Servicio = new Servicio();            
            return Servicio;
        }

        // No valida nada porque todos pueden consultar
        public void Leer() => ObtenerServicio().Leer();

        public void Actualizar()
        {
            if (Usuario.NivelPermiso >= 5) ObtenerServicio().Actualizar();
            else throw new UnauthorizedAccessException("No tenes permiso");
        }

        public void Eliminar()
        {
            if (Usuario.NivelPermiso >= 5) ObtenerServicio().Eliminar();
            else throw new UnauthorizedAccessException("No tenes permiso");
        }

        public void Escribir()
        {
            if (Usuario.NivelPermiso >= 5) ObtenerServicio().Escribir();
            else throw new UnauthorizedAccessException("No tenes permiso");
        }

    }
}
