using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace ParqueoProyecto
{
    public class AccesoDatos : Conexion
    {
        public int SqlCommand(string strSql)
        {
            SqlCommand sqlCmd = new SqlCommand();
            Int32 Resultado = 0;

            sqlCmd.CommandText = strSql;
            sqlCmd.Connection = cn;

            try
            {
                Abrir_cn();
                sqlCmd.ExecuteNonQuery();
                Resultado = 1;
            }

            catch
            {
                throw new Exception();
                Resultado = 0;
            }

            finally
            {
                Cerrar_cn();
                sqlCmd.Dispose();
            }

            return Resultado;
        }

        public DataTable Datos(string strSql)
        {
            SqlCommand sqlCmd = new SqlCommand();
            DataTable dts = new DataTable();

            sqlCmd.CommandText = strSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Connection = cn;

            SqlDataAdapter sqlda = new SqlDataAdapter(sqlCmd);

            try
            {
                Abrir_cn();
                sqlda.Fill(dts);
            }

            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("An error ocurred");
            }

            finally
            {
                Cerrar_cn();
                sqlCmd.Dispose();
            }

            return dts;
        }

        public string DatosNumericos(string strSql)
        {
            SqlCommand sqlCmd = new SqlCommand();
            string valorNumerico = "0";

            sqlCmd.CommandText = strSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Connection = cn;


            try
            {
                Abrir_cn();
                valorNumerico = (String) sqlCmd.ExecuteScalar().ToString();

            }

            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("An error ocurred: " + ex);
            }

            finally
            {
                Cerrar_cn();
                sqlCmd.Dispose();
            }

            return valorNumerico;
        }

        public void DatosComboBox(MetroComboBox cmb, string strSQL)
        {

            using (SqlConnection conn = new SqlConnection("Server=DISEÑO-PC\\SQLEXPRESS; Initial Catalog=PARQUEO;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(strSQL, conn);

                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    cmb.Items.Add(DR[0]);

                }

                cmb.SelectedIndex = 0;
                cmb.DropDownHeight = cmb.Font.Height * 20;
            } 
            

         }

    }
}
