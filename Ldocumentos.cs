using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using WebServiceApiRest.Models.Response;

namespace WebServiceApiRest.Models
{
    // la clase LDocumentos recoge todos los campos con la información de la tabla LDocumentos de la BD.
    // LDocumentos se asocia a cada fila que se encuentra en un documento. Estas filas recogen datos como
    // el precio del artículo que se asocia a la mesa y de qué tipo de artículo se trata
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

        // getLDocumento es utilizado para obtener la información de LDocumentos según su id.
        // Este método se utiliza a nivel de API.
        public Ldocumentos getLDocumento(int idLDocumento)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
                {
                    MySqlCommand cmd = null;
                    MySqlDataReader dr = null;

                    //se abre la conexión
                    conexion.Open();

                    // carga la línea de documento
                    cmd = new MySqlCommand("SELECT * FROM ldocumentos WHERE ldoc_id = @idLDocumento", conexion);
                    cmd.Parameters.AddWithValue("@idLDocumento", idLDocumento);

                    Ldocumentos objLDocumento = new Ldocumentos();
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        objLDocumento.ldoc_id = Convert.ToInt64(dr["ldoc_id"].ToString());
                        objLDocumento.ldoc_doc_id = Convert.ToInt64(dr["ldoc_doc_id"].ToString());
                        objLDocumento.ldoc_tipo = dr["ldoc_tipo"].ToString();
                        objLDocumento.ldoc_linea = Convert.ToInt32(dr["ldoc_linea"].ToString());
                        objLDocumento.ldoc_art_id = Convert.ToInt32(dr["ldoc_art_id"].ToString());
                        objLDocumento.ldoc_descripcion = dr["ldoc_descripcion"].ToString();
                        objLDocumento.ldoc_cantidad = Convert.ToDouble(dr["ldoc_cantidad"].ToString());
                        objLDocumento.ldoc_pvp = Convert.ToDouble(dr["ldoc_pvp"].ToString());
                        objLDocumento.ldoc_dto = Convert.ToDouble(dr["ldoc_dto"].ToString());
                        objLDocumento.ldoc_cdto = Convert.ToDouble(dr["ldoc_cdto"].ToString());
                        objLDocumento.ldoc_importe = Convert.ToDouble(dr["ldoc_importe"].ToString());
                        objLDocumento.ldoc_importe_pvp = Convert.ToDouble(dr["ldoc_importe_pvp"].ToString());
                        objLDocumento.ldoc_iva = Convert.ToDouble(dr["ldoc_iva"].ToString());
                        objLDocumento.ldoc_civa = Convert.ToDouble(dr["ldoc_civa"].ToString());
                        objLDocumento.ldoc_tipo_iva = Convert.ToInt32(dr["ldoc_tipo_iva"].ToString());
                        objLDocumento.ldoc_cant_prn = Convert.ToInt32(dr["ldoc_cant_prn"].ToString());
                        objLDocumento.ldoc_ter_id = Convert.ToInt32(dr["ldoc_ter_id"].ToString());
                        if (dr["ldoc_varia_notas"].ToString() == "")
                        {
                            objLDocumento.ldoc_varia_notas = 0;
                        }
                        else
                        {
                            objLDocumento.ldoc_varia_notas = Convert.ToInt32(dr["ldoc_varia_notas"].ToString());
                        }
                        objLDocumento.ldoc_err_prn = Convert.ToInt32(dr["ldoc_err_prn"].ToString());
                        objLDocumento.ldoc_usuario = Convert.ToInt32(dr["ldoc_usuario"].ToString());
                    }

                    return objLDocumento;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
