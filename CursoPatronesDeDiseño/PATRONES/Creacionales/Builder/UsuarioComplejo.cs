namespace CursoPatronesDeDiseño.PATRONES.Creacionales.Builder
{
    // TODO Pasar el ejemplo de Java a .NET
    public class UsuarioComplejo
    {
        // Campos obligatorios
        public string Nombre;
        public string Apellido;

        // Campos opcionales

        private bool MedioContacto;
        private string MetodoPago;
        private string Token;

        public string Email;
        public string Telefono;
        public string Direccion;        

        public UsuarioComplejo SetMedioContacto(bool medioContacto)
        {
            if (!medioContacto) throw new ArgumentException("No es posible asignar un valor falso a medio de contacto");

            MedioContacto = medioContacto;
            return new UsuarioComplejo("","");
            //return new BuilderUsuario(this);
        }

        private UsuarioComplejo(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

            MedioContacto = false;

            Email = "";
            Telefono = "";
            Direccion = "";
        }

        public static UsuarioComplejo Make(string nombre, string apellido) => new UsuarioComplejo(nombre, apellido);

        public UsuarioComplejo Build() => this;

        public override string ToString()
        {
            return "UsuarioComplejo{" +
                "nombre='" + Nombre + '\'' +
                ", apellido='" + Apellido + '\'' +
                ", email='" + Email + '\'' +
                ", telefono='" + Telefono + '\'' +
                ", direccion='" + Direccion + '\'' +
                $", metodoPago= {MetodoPago}" + '\'' +
                $"token= {Token}" + '\'' +
                '}';
        }
    }

    public class BuilderUsuario
    {
        private UsuarioComplejo UsuarioComplejo;

        public BuilderUsuario(UsuarioComplejo usuarioComplejo)
        {
            UsuarioComplejo = usuarioComplejo;
        }

        public BuilderUsuario SetEmail(string email)
        {
            UsuarioComplejo.Email = email;
            return this;
        }

        public BuilderUsuario SetTelefono(string telefono)
        {
            UsuarioComplejo.Telefono = telefono;
            return this;
        }

        public BuilderUsuario SetDireccion(string direccion)
        {
            UsuarioComplejo.Direccion = direccion;
            return this;
        }
    }
}