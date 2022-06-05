using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Configuracion
    {
        [Key]
        public int config_id { get; set; }
        public int config_agrupar_imprimir { get; set; }
        public int config_numero_salones { get; set; }
        public string config_descrip_salon1 { get; set; }
        public string config_descrip_salon2 { get; set; }
        public string config_descrip_salon3 { get; set; }
        public string config_descrip_salon4 { get; set; }
        public int config_usuario_imprime_caja { get; set; }
        public int config_pide_usuario { get; set; }
        public int config_tarifa_salon1 { get; set; }
        public int config_tarifa_salon2 { get; set; }
        public int config_tarifa_salon3 { get; set; }
        public int config_tarifa_salon4 { get; set; }
        public int config_imprime_resumen_ticket { get; set; }
        public int config_aviso_precio_cero { get; set; }
        public int config_actualizar_al_iniciar { get; set; }

    }
}
