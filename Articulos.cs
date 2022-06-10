using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Articulos
    {
        [Key]
        public int art_id { get; set; }
        public string art_nom { get; set; }
        [Required]
        public int art_orden { get; set; }
        public string art_nom_corto { get; set; }
        public string art_imagen { get; set; }
        public string art_nom_largo { get; set; }
        public string art_color_fondo { get; set; }
        public string art_color_fuente { get; set; }
        public int art_prn_comanda { get; set; }
        public int art_prn_auxiliar { get; set; }
        public int art_fam { get; set; }
        public int art_fam_comb { get; set; }
        public int art_fam_nota { get; set; }
        public int art_fam_suple { get; set; }
        public int art_tipo_iva { get; set; }
        public int art_fav1 { get; set; }
        public int art_fav2 { get; set; }
        public int art_fav3 { get; set; }
        public double art_inc_comb { get; set; }
        public string art_prn_auxiliar2 { get; set; }
        public double art_pvp { get; set; }

        public Articulos()
        { }
    }
}
