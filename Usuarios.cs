using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Usuarios
    {
        [Key]
        public int user_id { get; set; }
        public string user_nom { get; set; }
        public string user_pwd { get; set; }
        public int user_admin { get; set; }

        public Usuarios() { }

        public Usuarios(int user_id, string user_nom, string user_pwd)
        {
            this.user_id = user_id;
            this.user_nom = user_nom;
            this.user_pwd = user_pwd;
        }
    }
}
