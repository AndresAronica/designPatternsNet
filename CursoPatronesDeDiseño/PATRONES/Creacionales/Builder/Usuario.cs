namespace CursoPatronesDeDiseño.PATRONES.Creacionales.Builder
{
    // TODO Pasar el ejemplo de Java a .NET
    public class Usuario
    {
        // Campos obligatorios
        private string Nombre;
        private string Apellido;

        // Campos opcionales
        private string Email;
        private string Telefono;
        private string Direccion;

        public Usuario SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public Usuario SetTelefono(string telefono)
        {
            Telefono = telefono;
            return this;
        }

        public Usuario SetDireccion(string direccion)
        {
            Direccion = direccion;
            return this;
        }

        private Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

            Email = "";
            Telefono = "";
            Direccion = "";
        }

        public static Usuario Make(string nombre, string apellido) => new Usuario(nombre, apellido);

        public Usuario Build() => this;

        public override string ToString()
        {
            return "Usuario{" +
                "nombre='" + Nombre + '\'' +
                ", apellido='" + Apellido + '\'' +
                ", email='" + Email + '\'' +
                ", telefono='" + Telefono + '\'' +
                ", direccion='" + Direccion + '\'' +
                '}';
        }
    }
}
