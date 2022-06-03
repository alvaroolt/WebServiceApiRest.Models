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
            this.doc_serie = "MESA";
            this.doc_tipo = "TICKET";
            this.doc_fecha = DateTime.Now;
            this.doc_num = 1;
            this.doc_mesa = 1;
            this.doc_terminal = 1;
            this.doc_cliente = 1;
            this.doc_iva_id = 1;
            this.doc_bloqueado = 1;
        }

        public Documentos(Int64 doc_id)
        {
            this.doc_id = doc_id;
            this.doc_serie = "MESA";
            this.doc_tipo = "TICKET";
            this.doc_fecha = DateTime.Now;
            this.doc_num = 1;
            this.doc_mesa = 1;
            this.doc_terminal = 1;
            this.doc_cliente = 1;
            this.doc_iva_id = 1;
            this.doc_bloqueado = 1;
        }

        public Documentos(Int64 doc_id, int doc_bloqueado)
        {
            this.doc_id = doc_id;
            this.doc_bloqueado = doc_bloqueado;
        }

        public string actualizar()
        {
            string mensaje = "";
            MySqlTransaction transaction = default;
            using (MySqlConnection conexion = Conexion.getInstance().ConexionDB())
            {
                MySqlCommand cmd = new MySqlCommand();

                conexion.Open();
                cmd.Transaction = transaction;
                transaction = conexion.BeginTransaction();

                try
                {
                    string sCommand = String.Format("update documentos set doc_serie = '{0}', doc_num = {1}, doc_tipo = '{2}', doc_mesa = {3}, doc_cliente = {4}, doc_regimen_id = {5}, doc_fecha = '{6}', doc_fpago = {7}, doc_iva_id = {8}, " +
                        "doc_retencion = {9},doc_base1 = {10}, doc_base2 = {11}, doc_base3 = {12}, doc_base4 = {13}, doc_sum_bases = {14}, doc_cdto_pp = {15}, doc_civa1 = {16}, doc_civa2 = {17}," +
                        "doc_civa3 = {18}, doc_civa4 = {19}, doc_sum_civas = {20}, doc_crec1 = {21}, doc_crec2 = {22}, doc_crec3 = {23}, doc_crec4 = {24}, doc_sum_crec = {25}," +
                        "doc_cret1 = {26}, doc_cret2 = {27}, doc_cret3 = {28}, doc_cret4 = {29}, doc_sum_crets = {30},doc_total1 = {31},doc_total2 = {32}," +
                        "doc_total3 = {33},doc_total4 = {34},doc_total = {35},doc_terminal = {36},doc_entregado = {37},doc_bloqueado = {38},doc_caja_id = {39},doc_abonado = {40},doc_fecha_pedido = '{41}' where (doc_id = {42})",
                        doc_serie, doc_num, doc_tipo, doc_mesa, doc_cliente, doc_regimen_id, doc_fecha.ToString("yyyy-MM-dd hh:mm:ss"), doc_fpago, doc_iva_id,
                        doc_retencion.ToString().Replace(",", "."), doc_base1.ToString().Replace(",", "."),
                       doc_base2.ToString().Replace(",", "."), doc_base3.ToString().Replace(",", "."), doc_base4.ToString().Replace(",", "."),
                       doc_sum_bases.ToString().Replace(",", "."), doc_cdto_pp.ToString().Replace(",", "."), doc_civa1.ToString().Replace(",", "."), doc_civa2.ToString().Replace(",", "."),
                       doc_civa3.ToString().Replace(",", "."), doc_civa4.ToString().Replace(",", "."), doc_sum_civas.ToString().Replace(",", "."), doc_crec1.ToString().Replace(",", "."),
                       doc_crec2.ToString().Replace(",", "."), doc_crec3.ToString().Replace(",", "."), doc_crec4.ToString().Replace(",", "."), doc_sum_crec.ToString().Replace(",", "."),
                       doc_cret1.ToString().Replace(",", "."), doc_cret2.ToString().Replace(",", "."), doc_cret3.ToString().Replace(",", "."), doc_cret4.ToString().Replace(",", "."),
                       doc_sum_crets.ToString().Replace(",", "."), doc_total1.ToString().Replace(",", "."), doc_total2.ToString().Replace(",", "."), doc_total3.ToString().Replace(",", "."),
                       doc_total4.ToString().Replace(",", "."), doc_total.ToString().Replace(",", "."), doc_terminal, doc_entregado.ToString().Replace(",", "."),
                       doc_bloqueado, doc_caja_id, doc_abonado, doc_fecha_pedido.ToString("yyyy-MM-dd hh:mm:ss"), doc_id);

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
            return mensaje;
        }
    }
}
