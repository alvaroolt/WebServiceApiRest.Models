using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Familias_art
    {
        [Key]
        public int fam_id { get; set; }
        public string fam_nom { get; set; }
        public string fam_nom_corto { get; set; }
        public string fam_imagen { get; set; }
        public string fam_nom_largo { get; set; }
        public string fam_color_fondo { get; set; }
        public string fam_color_fuente { get; set; }
        [Required]
        public int fam_orden { get; set; }
        public int fam_visible { get; set; }

        public Familias_art()
        { }
    }
}
