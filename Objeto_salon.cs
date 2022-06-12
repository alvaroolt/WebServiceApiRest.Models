namespace WebServiceApiRest.Models
{

    // la clase Objetos_salon recoge el campo objsalon_orden (el número de la mesa/objeto de salón) con la información de la tabla Objetos_salon de la BD.
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
