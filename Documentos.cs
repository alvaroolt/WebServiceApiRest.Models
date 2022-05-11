using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Documentos
    {
        [Key]
        public Int64 doc_id { get; set; }
        public string doc_serie { get; set; }
        [Required]
        public int doc_num { get; set; }
        public string doc_tipo { get; set; }
        [Required]
        public int doc_mesa { get; set; }
        [Required]
        public int doc_cliente { get; set; }
        [Required]
        public int doc_regimen_id { get; set; }
        public DateTime doc_fecha { get; set; }
        [Required]
        public int doc_fpago { get; set; }
        [Required]
        public int doc_iva_id { get; set; }
        public double doc_retencion { get; set; }
        public double doc_base1 { get; set; }
        public double doc_base2 { get; set; }
        public double doc_base3 { get; set; }
        public double doc_base4 { get; set; }
        public double doc_sum_bases { get; set; }
        public double doc_cdto_pp { get; set; }
        public double doc_civa1 { get; set; }
        public double doc_civa2 { get; set; }
        public double doc_civa3 { get; set; }
        public double doc_civa4 { get; set; }
        public double doc_sum_civas { get; set; }
        public double doc_crec1 { get; set; }
        public double doc_crec2 { get; set; }
        public double doc_crec3 { get; set; }
        public double doc_crec4 { get; set; }
        public double doc_sum_crec { get; set; }
        public double doc_cret1 { get; set; }
        public double doc_cret2 { get; set; }
        public double doc_cret3 { get; set; }
        public double doc_cret4 { get; set; }
        public double doc_sum_crets { get; set; }
        public double doc_total1 { get; set; }
        public double doc_total2 { get; set; }
        public double doc_total3 { get; set; }
        public double doc_total4 { get; set; }
        public double doc_total { get; set; }
        [Required]
        public int doc_terminal { get; set; }
        public double doc_entregado { get; set; }
        [Required]
        public int doc_bloqueado { get; set; }
        [Required]
        public int doc_caja_id { get; set; }
        public int doc_abonado { get; set; }
        public List<Ldocumentos> listdoc { get; set; }

        public Documentos()
        {
            this.doc_serie = "MESA";
            this.doc_tipo = "TICKET";
            this.doc_fecha = DateTime.Now;
            this.doc_num = 1;
            this.doc_mesa = 1;
            this.doc_terminal = 1;
            this.doc_cliente = 1;
            this.doc_iva_id = 1;
            this.doc_bloqueado = 1;
        }

        public Documentos(Int64 doc_id)
        {
            this.doc_id = doc_id;
            this.doc_serie = "MESA";
            this.doc_tipo = "TICKET";
            this.doc_fecha = DateTime.Now;
            this.doc_num = 1;
            this.doc_mesa = 1;
            this.doc_terminal = 1;
            this.doc_cliente = 1;
            this.doc_iva_id = 1;
            this.doc_bloqueado = 1;
        }
    }
}
