using System.ComponentModel.DataAnnotations;

namespace WebServiceApiRest.Models
{
    // la clase Terminal recoge los campos ter_id (identificador), ter_nom (nombre del terminal) y ter_bloqueado (estado de bloqueo del terminal)
    // con la información de la tabla Terminal de la BD.
    public class Terminal
    {
        [Key]
        public int ter_id { get; set; }
        public string ter_nom { get; set; }
        public int ter_bloqueado { get; set; }

        public Terminal() { }

        public Terminal(int ter_id, string ter_nom, int ter_bloqueado)
        {
            this.ter_id = ter_id;
            this.ter_nom = ter_nom;
            this.ter_bloqueado = ter_bloqueado;
        }

        public Terminal(int ter_id, int ter_bloqueado)
        {
            this.ter_id = ter_id;
            this.ter_bloqueado = ter_bloqueado;
        }
    }
}
