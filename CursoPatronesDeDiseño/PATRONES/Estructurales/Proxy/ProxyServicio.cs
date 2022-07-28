namespace CursoPatronesDeDiseño.PATRONES.Estructurales.Proxy
{
    /// <summary>
    /// Implementacion de <b>Proxy.</b> Su intencion es limitar funcionalidad del sistema.<br></br>
    /// Generalmente se utiliza por motivos de seguridad. <br></br>
    /// En este caso es un Proxy para la clase Servicio. Al principio no tenia permisos de usuario. Luego se agregaron. <br></br>
    /// Para no reescribir ese codigo, se hace un proxy que valida por los permisos y si esta ok le patea la ejecucion al Servicio.
    /// </summary>
    public class ProxyServicio : IServicio
    {
        private IServicio Servicio;
        private Usuario Usuario;

        public ProxyServicio(IServicio servicio, Usuario usuario)
        {
            Servicio = servicio;
            Usuario = usuario;
        }
        
        // No valida nada porque todos pueden consultar
        public void Leer() => Servicio.Leer();

        public void Actualizar()
        {
            if (Usuario.NivelPermiso >= 5) Servicio.Actualizar();
            else throw new UnauthorizedAccessException("No tenes permiso");
        }

        public void Eliminar()
        {
            if (Usuario.NivelPermiso >= 5) Servicio.Eliminar();
            else throw new UnauthorizedAccessException("No tenes permiso");
        }

        public void Escribir()
        {
            if (Usuario.NivelPermiso >= 5) Servicio.Escribir();
            else throw new UnauthorizedAccessException("No tenes permiso");
        }

    }
}
