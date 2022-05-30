using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Terminal
    {
        [Key]
        public int ter_id { get; set; }
        public string ter_nom { get; set; }
        //public int ter_caja { get; set; }
        //public int ter_prn_ticket { get; set; }
        //public int ter_prn_cocina1 { get; set; }
        //public int ter_prn_cocina2 { get; set; }
        //public string ter_param_cajon { get; set; }
        public int ter_bloqueado { get; set; }
        //public string ter_ruta_copia { get; set; }
        //public int ter_copia { get; set; }
        //public int ter_prn_auxiliar2 { get; set; }
        //public int ter_numero_copias_ticket { get; set; }
        //public int ter_numero_copias_comanda { get; set; }
        //public int ter_numero_copias_auxiliar { get; set; }
        //public int ter_numero_copias_auxiliar2 { get; set; }
        //public string ter_puerto { get; set; }
        //public int ter_numero_copias_factura { get; set; }
        //public string ter_formato_ticket { get; set; }
        //public string ter_prn_factura { get; set; }
        //public string ter_nom_pc_user { get; set; }

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
