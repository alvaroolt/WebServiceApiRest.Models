using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Ldocumentos
    {
        [Key]
        public Int64 ldoc_id { get; set; }
        [Required]
        public Int64 ldoc_doc_id { get; set; }
        public string ldoc_tipo { get; set; }
        [Required]
        public int ldoc_linea { get; set; }
        [Required]
        public int ldoc_art_id { get; set; }
        public string ldoc_descripcion { get; set; }
        [Required]
        public double ldoc_cantidad { get; set; }
        [Required]
        public double ldoc_pvp { get; set; }
        [Required]
        public double ldoc_dto { get; set; }
        [Required]
        public double ldoc_cdto { get; set; }
        [Required]
        public double ldoc_importe { get; set; }
        [Required]
        public double ldoc_importe_pvp { get; set; }
        [Required]
        public double ldoc_iva { get; set; }
        [Required]
        public double ldoc_civa { get; set; }
        [Required]
        public int ldoc_tipo_iva { get; set; }
        [Required]
        public int ldoc_cant_prn { get; set; }
        [Required]
        public int ldoc_ter_id { get; set; }
        public int ldoc_varia_notas { get; set; }
        public int ldoc_err_prn { get; set; }
        public int ldoc_usuario { get; set; }

        public Ldocumentos() { }

        public Ldocumentos(Int64 ldoc_id)
        {
            this.ldoc_id = ldoc_id;
        }
    }
}
