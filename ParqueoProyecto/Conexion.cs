using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueoProyecto
{
    public class Conexion
    {
        public static SqlConnection cn;

        public Conexion()
        {
            //  cn = new SqlConnection("Server=langt061;Database=scentia;User Id=sa");
            cn = new SqlConnection("Server=DISEÑO-PC\\SQLEXPRESS; Initial Catalog=PARQUEO;Integrated Security=True;");

        }

        public void Abrir_cn()
        {
            try
            {
                if (cn.State == ConnectionState.Broken || cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Cerrar_cn()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
