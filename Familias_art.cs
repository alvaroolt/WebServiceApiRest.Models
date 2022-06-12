using System.ComponentModel.DataAnnotations;

namespace WebServiceApiRest.Models
{
    // la clase Familias_art recoge todos los campos con la información de la tabla Familias_art de la BD.
    // Estos datos pertenecen a las diferentes categorías de artículos disponibles en el restaurante/empresa.
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
