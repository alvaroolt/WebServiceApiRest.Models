using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using WebServiceApiRest.Models.Response;

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
        public DateTime doc_fecha_pedido { get; set; }
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
            doc_serie = "MESA";
            doc_tipo = "TICKET";
            doc_fecha = DateTime.Now;
            doc_num = 1;
            doc_mesa = 1;
            doc_terminal = 1;
            doc_cliente = 1;
            doc_iva_id = 1;
            doc_bloqueado = 1;
        }

        public Documentos(Int64 docId)
        {
            doc_id = docId;
            doc_serie = "MESA";
            doc_tipo = "TICKET";
            doc_fecha = DateTime.Now;
            doc_num = 1;
            doc_mesa = 1;
            doc_terminal = 1;
            doc_cliente = 1;
            doc_iva_id = 1;
            doc_bloqueado = 1;
        }

        public Documentos getDocumento(int idDocumento)
        {
            try
            {
                using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
                {
                    MySqlCommand cmd = null;
                    MySqlDataReader dr = null;

                    //se abre la conexión
                    conexion.Open();

                    // carga el documento y sus lineas
                    cmd = new MySqlCommand("SELECT doc.*,ldoc.* FROM documentos AS doc LEFT JOIN ldocumentos AS LDOC ON doc.DOC_ID = LDOC.LDOC_DOC_ID WHERE doc.DOC_ID = @idDocumento", conexion);
                    //se le asigna el valor de mesa a @orden
                    cmd.Parameters.AddWithValue("@idDocumento", idDocumento);

                    //se obtiene cada usuario con sus valores, y se les añade a la lista de usuarios
                    int cont = 0;

                    Documentos objDocumento = new Documentos();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cont++;
                        string cadena = dr["doc_id"].ToString();
                        if (cadena == "")
                        {
                            objDocumento.doc_id = 0;
                        }
                        else
                        {
                            if (cont == 1)
                            {
                                objDocumento.doc_id = Convert.ToInt64(dr["doc_id"].ToString());
                                objDocumento.doc_serie = dr["doc_serie"].ToString();
                                objDocumento.doc_num = Convert.ToInt32(dr["doc_num"].ToString());
                                objDocumento.doc_tipo = dr["doc_tipo"].ToString();
                                objDocumento.doc_mesa = Convert.ToInt32(dr["doc_mesa"].ToString());
                                objDocumento.doc_cliente = Convert.ToInt32(dr["doc_cliente"].ToString());
                                objDocumento.doc_regimen_id = Convert.ToInt32(dr["doc_regimen_id"].ToString());
                                objDocumento.doc_fecha = Convert.ToDateTime(dr["doc_fecha"].ToString());
                                objDocumento.doc_fpago = Convert.ToInt32(dr["doc_fpago"].ToString());
                                objDocumento.doc_iva_id = Convert.ToInt32(dr["doc_iva_id"].ToString());
                                objDocumento.doc_retencion = Convert.ToDouble(dr["doc_retencion"].ToString());
                                objDocumento.doc_base1 = Convert.ToDouble(dr["doc_base1"].ToString());
                                objDocumento.doc_base2 = Convert.ToDouble(dr["doc_base2"].ToString());
                                objDocumento.doc_base3 = Convert.ToDouble(dr["doc_base3"].ToString());
                                objDocumento.doc_base4 = Convert.ToDouble(dr["doc_base4"].ToString());
                                objDocumento.doc_sum_bases = Convert.ToDouble(dr["doc_sum_bases"].ToString());
                                objDocumento.doc_cdto_pp = Convert.ToDouble(dr["doc_cdto_pp"].ToString());
                                objDocumento.doc_civa1 = Convert.ToDouble(dr["doc_civa1"].ToString());
                                objDocumento.doc_civa2 = Convert.ToDouble(dr["doc_civa2"].ToString());
                                objDocumento.doc_civa3 = Convert.ToDouble(dr["doc_civa3"].ToString());
                                objDocumento.doc_civa4 = Convert.ToDouble(dr["doc_civa4"].ToString());
                                objDocumento.doc_sum_civas = Convert.ToDouble(dr["doc_sum_civas"].ToString());
                                objDocumento.doc_crec1 = Convert.ToDouble(dr["doc_crec1"].ToString());
                                objDocumento.doc_crec2 = Convert.ToDouble(dr["doc_crec2"].ToString());
                                objDocumento.doc_crec3 = Convert.ToDouble(dr["doc_crec3"].ToString());
                                objDocumento.doc_crec4 = Convert.ToDouble(dr["doc_crec4"].ToString());
                                objDocumento.doc_sum_crec = Convert.ToDouble(dr["doc_sum_crec"].ToString());
                                objDocumento.doc_cret1 = Convert.ToDouble(dr["doc_cret1"].ToString());
                                objDocumento.doc_cret2 = Convert.ToDouble(dr["doc_cret2"].ToString());
                                objDocumento.doc_cret3 = Convert.ToDouble(dr["doc_cret3"].ToString());
                                objDocumento.doc_cret4 = Convert.ToDouble(dr["doc_cret4"].ToString());
                                objDocumento.doc_sum_crets = Convert.ToDouble(dr["doc_sum_crets"].ToString());
                                objDocumento.doc_total1 = Convert.ToDouble(dr["doc_total1"].ToString());
                                objDocumento.doc_total2 = Convert.ToDouble(dr["doc_total2"].ToString());
                                objDocumento.doc_total3 = Convert.ToDouble(dr["doc_total3"].ToString());
                                objDocumento.doc_total4 = Convert.ToDouble(dr["doc_total4"].ToString());
                                objDocumento.doc_total = Convert.ToDouble(dr["doc_total"].ToString());
                                objDocumento.doc_terminal = Convert.ToInt32(dr["doc_terminal"].ToString());
                                objDocumento.doc_entregado = Convert.ToDouble(dr["doc_entregado"].ToString());
                                objDocumento.doc_bloqueado = Convert.ToInt32(dr["doc_bloqueado"].ToString());
                                objDocumento.doc_caja_id = Convert.ToInt32(dr["doc_caja_id"].ToString());
                                objDocumento.doc_abonado = Convert.ToInt32(dr["doc_abonado"].ToString());
                                objDocumento.listdoc = new List<Ldocumentos>();
                            }

                            string cadena2 = dr["ldoc_id"].ToString();
                            if (cadena2 != "")
                            {
                                Ldocumentos ldoc = new Ldocumentos();

                                ldoc.ldoc_id = Convert.ToInt64(dr["ldoc_id"].ToString());
                                ldoc.ldoc_doc_id = Convert.ToInt64(dr["ldoc_doc_id"].ToString());
                                ldoc.ldoc_tipo = dr["ldoc_tipo"].ToString();
                                ldoc.ldoc_linea = Convert.ToInt32(dr["ldoc_linea"].ToString());
                                ldoc.ldoc_art_id = Convert.ToInt32(dr["ldoc_art_id"].ToString());
                                ldoc.ldoc_descripcion = dr["ldoc_descripcion"].ToString();
                                ldoc.ldoc_cantidad = Convert.ToDouble(dr["ldoc_cantidad"].ToString());
                                ldoc.ldoc_pvp = Convert.ToDouble(dr["ldoc_pvp"].ToString());
                                ldoc.ldoc_dto = Convert.ToDouble(dr["ldoc_dto"].ToString());
                                ldoc.ldoc_cdto = Convert.ToDouble(dr["ldoc_cdto"].ToString());
                                ldoc.ldoc_importe = Convert.ToDouble(dr["ldoc_importe"].ToString());
                                ldoc.ldoc_importe_pvp = Convert.ToDouble(dr["ldoc_importe_pvp"].ToString());
                                ldoc.ldoc_iva = Convert.ToDouble(dr["ldoc_iva"].ToString());
                                ldoc.ldoc_civa = Convert.ToDouble(dr["ldoc_civa"].ToString());
                                ldoc.ldoc_tipo_iva = Convert.ToInt32(dr["ldoc_tipo_iva"].ToString());
                                ldoc.ldoc_cant_prn = Convert.ToInt32(dr["ldoc_cant_prn"].ToString());
                                ldoc.ldoc_ter_id = Convert.ToInt32(dr["ldoc_ter_id"].ToString());

                                if (dr["ldoc_varia_notas"].ToString() == "")
                                {
                                    ldoc.ldoc_varia_notas = 0;
                                }
                                else
                                {
                                    ldoc.ldoc_varia_notas = Convert.ToInt32(dr["ldoc_varia_notas"].ToString());
                                }
                                ldoc.ldoc_err_prn = Convert.ToInt32(dr["ldoc_err_prn"].ToString());
                                ldoc.ldoc_usuario = Convert.ToInt32(dr["ldoc_usuario"].ToString());

                                objDocumento.listdoc.Add(ldoc);
                            }
                        }
                    }

                    return objDocumento;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Documentos(Int64 doc_id, int doc_bloqueado)
        {
            doc_id = doc_id;
            doc_bloqueado = doc_bloqueado;
        }

        public string actualizar(MySqlCommand cmdex)
        {
            string mensaje = "";
            string sCommand = String.Format("update documentos set doc_serie = '{0}', doc_num = {1}, doc_tipo = '{2}', doc_mesa = {3}, doc_cliente = {4}, doc_regimen_id = {5}, doc_fecha = '{6}', doc_fpago = {7}, doc_iva_id = {8}, " +
                        "doc_retencion = {9},doc_base1 = {10}, doc_base2 = {11}, doc_base3 = {12}, doc_base4 = {13}, doc_sum_bases = {14}, doc_cdto_pp = {15}, doc_civa1 = {16}, doc_civa2 = {17}," +
                        "doc_civa3 = {18}, doc_civa4 = {19}, doc_sum_civas = {20}, doc_crec1 = {21}, doc_crec2 = {22}, doc_crec3 = {23}, doc_crec4 = {24}, doc_sum_crec = {25}," +
                        "doc_cret1 = {26}, doc_cret2 = {27}, doc_cret3 = {28}, doc_cret4 = {29}, doc_sum_crets = {30},doc_total1 = {31},doc_total2 = {32}," +
                        "doc_total3 = {33},doc_total4 = {34},doc_total = {35},doc_terminal = {36},doc_entregado = {37},doc_bloqueado = {38},doc_caja_id = {39},doc_abonado = {40},doc_fecha_pedido = '{41}' where (doc_id = {42})",
                        doc_serie, doc_num, doc_tipo, doc_mesa, doc_cliente, doc_regimen_id, doc_fecha.ToString("yyyy-MM-dd HH:mm:ss"), doc_fpago, doc_iva_id,
                        doc_retencion.ToString().Replace(",", "."), doc_base1.ToString().Replace(",", "."),
                       doc_base2.ToString().Replace(",", "."), doc_base3.ToString().Replace(",", "."), doc_base4.ToString().Replace(",", "."),
                       doc_sum_bases.ToString().Replace(",", "."), doc_cdto_pp.ToString().Replace(",", "."), doc_civa1.ToString().Replace(",", "."), doc_civa2.ToString().Replace(",", "."),
                       doc_civa3.ToString().Replace(",", "."), doc_civa4.ToString().Replace(",", "."), doc_sum_civas.ToString().Replace(",", "."), doc_crec1.ToString().Replace(",", "."),
                       doc_crec2.ToString().Replace(",", "."), doc_crec3.ToString().Replace(",", "."), doc_crec4.ToString().Replace(",", "."), doc_sum_crec.ToString().Replace(",", "."),
                       doc_cret1.ToString().Replace(",", "."), doc_cret2.ToString().Replace(",", "."), doc_cret3.ToString().Replace(",", "."), doc_cret4.ToString().Replace(",", "."),
                       doc_sum_crets.ToString().Replace(",", "."), doc_total1.ToString().Replace(",", "."), doc_total2.ToString().Replace(",", "."), doc_total3.ToString().Replace(",", "."),
                       doc_total4.ToString().Replace(",", "."), doc_total.ToString().Replace(",", "."), doc_terminal, doc_entregado.ToString().Replace(",", "."),
                       doc_bloqueado, doc_caja_id, doc_abonado, doc_fecha_pedido.ToString("yyyy-MM-dd HH:mm:ss"), doc_id);

            if (cmdex == null)
            {
                MySqlTransaction transaction = default;
                using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
                {

                    MySqlCommand cmd = new MySqlCommand();

                    conexion.Open();
                    cmd.Transaction = transaction;
                    transaction = conexion.BeginTransaction();

                    try
                    {


                        cmd = new MySqlCommand(sCommand, conexion);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        mensaje = e.Message;
                        transaction.Rollback();
                    }
                    conexion.Close();

                }
            }
            else
            {
                cmdex.CommandText = sCommand;
                cmdex.ExecuteNonQuery();
            }

            return mensaje;
        }

        public string recalcularPrecio(int idDocumento, double importe_con_iva, int tipo_iva, double civa, MySqlCommand cmd)
        {
            string stmsg;
            Documentos objdocumento = new Documentos();
            objdocumento = objdocumento.getDocumento(idDocumento);

            try
            {
                switch (tipo_iva)
                {
                    case 0:
                        {
                            // normal
                            doc_total1 += importe_con_iva;
                            if (doc_total1 <= 0)
                            {
                                doc_civa1 = 0;
                                doc_base1 = 0;
                                doc_total1 = 0;
                                doc_civa1 = 0;
                            }
                            else
                            {
                                doc_civa1 = doc_civa1 + (importe_con_iva - importe_con_iva / (1 + civa / 100));
                                doc_base1 = Math.Round(doc_total1 - doc_civa1, 5);
                                doc_total1 = Math.Round(doc_total1, 5);
                                doc_civa1 = Math.Round(doc_civa1, 5);
                            }
                            break;
                        }

                    case 1:
                        {
                            // reducido
                            doc_total2 += importe_con_iva;
                            if (doc_total2 <= 0)
                            {
                                doc_civa2 = 0;
                                doc_base2 = 0;
                                doc_total2 = 0;
                                doc_civa2 = 0;
                            }
                            else
                            {
                                doc_civa2 = doc_civa2 + (importe_con_iva - importe_con_iva / (1 + civa / 100));
                                doc_base2 = Math.Round(doc_total2 - doc_civa2, 5);
                                doc_total2 = Math.Round(doc_total2, 5);
                                doc_civa2 = Math.Round(doc_civa2, 5);
                            }
                            break;
                        }


                    case 2:
                        {
                            // superreducido
                            doc_total3 += importe_con_iva;
                            if (doc_total3 <= 0)
                            {
                                doc_civa3 = 0;
                                doc_base3 = 0;
                                doc_total3 = 0;
                                doc_civa3 = 0;
                            }
                            else
                            {
                                doc_civa3 = doc_civa3 + (importe_con_iva - importe_con_iva / (1 + civa / 100));
                                doc_base3 = Math.Round(doc_total3 - doc_civa3, 5);
                                doc_total3 = Math.Round(doc_total3, 5);
                                doc_civa3 = Math.Round(doc_civa3, 5);
                            }
                            break;
                        }

                    case 3:
                        {
                            // exento
                            doc_total4 += importe_con_iva;
                            if (doc_total4 <= 0)
                            {
                                doc_civa4 = 0;
                                doc_base4 = 0;
                                doc_total4 = 0;
                                doc_civa4 = 0;
                            }
                            else
                            {
                                doc_civa4 = doc_civa4 + (importe_con_iva - importe_con_iva / (1 + civa / 100));
                                doc_base4 = Math.Round(doc_total4 - doc_civa4, 5);
                                doc_total4 = Math.Round(doc_total4, 5);
                                doc_civa4 = Math.Round(doc_civa4, 5);
                            }
                            break;
                        }
                }
                doc_sum_bases = Math.Round(doc_base1 + doc_base2 + doc_base3 + doc_base4, 5);
                doc_sum_civas = Math.Round(doc_civa1 + doc_civa2 + doc_civa3 + doc_civa4, 5);
                doc_total = Math.Round(doc_total1 + doc_total2 + doc_total3 + doc_total4, 2);
                stmsg = actualizar(cmd); // actualiza documento.
            }
            catch (Exception ex)
            {
                stmsg = ex.Message;
            }
            return stmsg;
        }

        public void crearCabeceraDocumento(int docMesa, int idTerminal)
        {
            doc_serie = "MESA"; // la serie
            doc_tipo = "TICKET"; // el tipo
            doc_fecha = DateTime.Now; // .ToString("yyyy-mm-dd hh:mm:ss")
            doc_num = (int)ultimoNumero("TICKET", "MESA") + 1; // mirar el último ticket de esta serie y este tipo
            doc_mesa = docMesa;
            doc_terminal = idTerminal;
            doc_cliente = 1;
            doc_regimen_id = 0;
            doc_fpago = 0;
            doc_iva_id = obtenerIvaEmpresa();
            doc_base1 = 0;
            doc_base2 = 0;
            doc_base3 = 0;
            doc_base4 = 0;
            doc_sum_bases = 0;
            doc_cdto_pp = 0;
            doc_civa1 = 0;
            doc_civa2 = 0;
            doc_civa3 = 0;
            doc_civa4 = 0;
            doc_sum_civas = 0;
            doc_total = 0;
            doc_total1 = 0;
            doc_total2 = 0;
            doc_total3 = 0;
            doc_total4 = 0;
            doc_entregado = 0;
            doc_bloqueado = 1;

            string stmsg = crearDocumento();
            if (stmsg.Length == 0)
            {
                doc_id = (Int64)id_documento(doc_tipo, doc_serie, doc_num);
            }
            else
            {
                doc_id = 0;
            }

        }

        public static object ultimoNumero(string stTipoDoc, string stserie)
        {
            string sqlMax;

            sqlMax = string.Format("SELECT coalesce(max(doc_num),0) FROM documentos where DOC_TIPO='{0}' and DOC_SERIE='{1}'", stTipoDoc, stserie);


            using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
            {
                try
                {
                    var cmd = new MySqlCommand(sqlMax, conexion);
                    conexion.Open();
                    return cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    return 0;
                }

            }
        }

        public int obtenerIvaEmpresa()
        {
            int ivaEmpresa = 0;
            try
            {
                using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
                {

                    MySqlCommand cmd = new MySqlCommand();
                    MySqlDataReader dr = null;

                    conexion.Open();

                    cmd = new MySqlCommand("SELECT * FROM empresa WHERE empresa.EMP_ID = 1; ", conexion);

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ivaEmpresa = Convert.ToInt32(dr["EMP_IVA"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception();
            }

            return ivaEmpresa;
        }

        public static object id_documento(string stTipoDoc, string stserie, int numero)
        {
            string sqlMax = string.Format("SELECT doc_id FROM documentos WHERE doc_tipo='{0}' and doc_serie='{1}' and doc_num={2}", stTipoDoc, stserie, numero);
            using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
            {
                try
                {
                    var cmd = new MySqlCommand(sqlMax, conexion);
                    conexion.Open();
                    return cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }


        public string crearDocumento()
        {
            // Crear un nuevo registro
            string sCommand = string.Format("INSERT INTO DOCUMENTOS (DOC_SERIE, DOC_NUM, DOC_TIPO, DOC_MESA, DOC_CLIENTE, DOC_REGIMEN_ID," +
                " DOC_FECHA, DOC_FPAGO, DOC_IVA_ID, DOC_RETENCION, DOC_BASE1, DOC_BASE2, DOC_BASE3, DOC_BASE4, DOC_SUM_BASES, DOC_CDTO_PP, " +
                "DOC_CIVA1, DOC_CIVA2, DOC_CIVA3, DOC_CIVA4, DOC_SUM_CIVAS, DOC_CREC1, DOC_CREC2, DOC_CREC3, DOC_CREC4, DOC_SUM_CREC, DOC_CRET1," +
                " DOC_CRET2, DOC_CRET3, DOC_CRET4, DOC_SUM_CRETS, DOC_TOTAL1, DOC_TOTAL2, DOC_TOTAL3, DOC_TOTAL4, DOC_TOTAL,DOC_TERMINAL, " +
                "DOC_ENTREGADO, DOC_BLOQUEADO,DOC_CAJA_ID,DOC_ABONADO,DOC_FECHA_PEDIDO) VALUES ( '{0}', {1}, '{2}', {3}, {4}, {5}, '{6}', {7}, {8}, " +
                "{9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, " +
                "{30}, {31},{32},{33},{34},{35},{36},{37},{38},{39},{40},'{41}')", doc_serie, doc_num, doc_tipo, doc_mesa, doc_cliente, doc_regimen_id, doc_fecha.ToString("yyyy-MM-dd HH:mm:ss"), doc_fpago, doc_iva_id, doc_retencion.ToString().Replace(",", "."), doc_base1.ToString().Replace(",", "."), doc_base2.ToString().Replace(",", "."), doc_base3.ToString().Replace(",", "."), doc_base4.ToString().Replace(",", "."), doc_sum_bases.ToString().Replace(",", "."), doc_cdto_pp.ToString().Replace(",", "."), doc_civa1.ToString().Replace(",", "."), doc_civa2.ToString().Replace(",", "."), doc_civa3.ToString().Replace(",", "."), doc_civa4.ToString().Replace(",", "."), doc_sum_civas.ToString().Replace(",", "."), doc_crec1.ToString().Replace(",", "."), doc_crec2.ToString().Replace(",", "."), doc_crec3.ToString().Replace(",", "."), doc_crec4.ToString().Replace(",", "."), doc_sum_crec.ToString().Replace(",", "."), doc_cret1.ToString().Replace(",", "."), doc_cret2.ToString().Replace(",", "."), doc_cret3.ToString().Replace(",", "."), doc_cret4.ToString().Replace(",", "."), doc_sum_crets.ToString().Replace(",", "."), doc_total1.ToString().Replace(",", "."), doc_total2.ToString().Replace(",", "."), doc_total3.ToString().Replace(",", "."), doc_total4.ToString().Replace(",", "."), doc_total.ToString().Replace(",", "."), doc_terminal, doc_entregado.ToString().Replace(",", "."), doc_bloqueado, doc_caja_id, doc_abonado, doc_fecha_pedido.ToString("yyyy-MM-dd HH:mm:ss"));

            using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
            {
                try
                {
                    var cmd = new MySqlCommand(sCommand, conexion);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
