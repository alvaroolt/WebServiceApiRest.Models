using System.ComponentModel.DataAnnotations;

namespace WebServiceApiRest.Models
{
    public class Usuarios
    {
        // la clase Usuarios recoge todos los campos con la información de la tabla Usuarios de la BD.
        [Key]
        public int user_id { get; set; }
        public string user_nom { get; set; }
        public string user_pwd { get; set; }
        public RolUsuario user_rol { get; set; } = RolUsuario.Usuario;

        public Usuarios() { }

        public Usuarios(int user_id, string user_nom, string user_pwd, RolUsuario user_rol)
        {
            this.user_id = user_id;
            this.user_nom = user_nom;
            this.user_pwd = user_pwd;
            this.user_rol = user_rol;
        }

        public enum RolUsuario : int
        {
            Administrador = 0,
            Usuario = 1
        }
    }
}
