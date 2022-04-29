using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Objeto_salon
    {
        public int objsalon_orden { get; set; }

        public Objeto_salon() { }

        public Objeto_salon(int objsalon_orden)
        {
            this.objsalon_orden = objsalon_orden;
        }
    }
}
