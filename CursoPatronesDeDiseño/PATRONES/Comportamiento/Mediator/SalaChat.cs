namespace CursoPatronesDeDiseño.PATRONES.Comportamiento.Mediator
{
    /// <summary>
    /// Implementacion de Mediator
    /// </summary>
    public class SalaChat
    {
        private Dictionary<string, Usuario> _usuarios;

        public SalaChat() => _usuarios = new Dictionary<string, Usuario>();

        public void AgregarParticipante(Usuario usuario) => _usuarios.Add(usuario.Nombre, usuario);

        public void EnviarMensaje(Usuario remitente, Usuario receptor, string mensaje)
        {
            if (_usuarios.ContainsKey(remitente.Nombre) &&
                _usuarios.ContainsKey(receptor.Nombre) &&
                !string.IsNullOrWhiteSpace(mensaje))
            {
                mensaje = $"Mensaje de {remitente.Nombre} para {receptor.Nombre}: {mensaje}";
                receptor.RecibirMensaje(mensaje);
            }
        }
    }
}
