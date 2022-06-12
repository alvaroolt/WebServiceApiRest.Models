using System.ComponentModel.DataAnnotations;

namespace WebServiceApiRest.Models
{
    // la clase Codebars recoge todos los campos con la información de la tabla Codebars de la BD.
    // Codebars es utilizado para añadir artículos a la mesa mediante un código de barras, sin necesidad
    // de buscar el artículo entre la lista de botones.
    public class Codebars
    {
        [Key]
        public int cbar_art_id { get; set; }
        public string cbar_code { get; set; }

        public Codebars()
        {
            cbar_art_id = 0;
            cbar_code = "";
        }
    }
}
