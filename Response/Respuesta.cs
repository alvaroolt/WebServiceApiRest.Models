// la clase Respuesta es utilizada para obtener información de la petición que se realiza (si hubo éxito, un mensaje y datos si hubieran)
// esta clase puede mandar cualquier objeto (o lista de objetos) en Data

namespace WebServiceApiRest.Models.Response
{
    public class Respuesta<T>
    {
        // 1 éxito / 0 error
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }

        public Respuesta()
        {
            this.Exito = 0;
        }
    }
}
