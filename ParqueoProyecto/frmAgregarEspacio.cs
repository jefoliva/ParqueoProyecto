using MetroFramework;
using System;
using System.Data;
using System.Windows.Forms;

namespace ParqueoProyecto
{
    public partial class frmAgregarEspacio : MetroFramework.Forms.MetroForm
    {
        AccesoDatos comando = new AccesoDatos();
        public frmAgregarEspacio()
        {
            InitializeComponent();
        }

        private void frmAgregarEspacio_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEstacionamiento_Click(object sender, EventArgs e)
        {
            string nuevaUbicacion = txtNuevoEstacionamiento.Text.Trim();
            bool nombreExiste = false;

            string consulta = "SELECT NIVEL FROM UBICACION";
            DataTable data = comando.Datos(consulta);

            string actual = "";

            for(int i = 0; i < data.Rows.Count; i++)
            {
                actual = data.Rows[i][0].ToString().Trim();

                if ( actual.Equals(nuevaUbicacion))
                {
                    nombreExiste = true;
                }

            }

            if ( nombreExiste )
            {
                MetroMessageBox.Show(this, "Ya existe una ubicacion con ese nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            } 
            else if( nuevaUbicacion.Length != 2)
            {
                MetroMessageBox.Show(this, "Nombre de ubicacion solo debe contener dos caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            try
              {
                  consulta = "INSERT INTO UBICACION(ID_ESTACION, NIVEL) VALUES ('1', '"+  nuevaUbicacion + "')";
                  comando.SqlCommand(consulta);

                  MetroMessageBox.Show(this, "Ubicacion agregada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

              }
              catch (Exception ex)
              {
                  MetroMessageBox.Show(this, "Ocurrio un error, no se pudo agregar la ubicacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

              }


        }
    }
}
