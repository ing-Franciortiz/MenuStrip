using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngendaMDI
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add(
                 txtNombre.Text,
                 txtApellido.Text,
                 txtEdad.Text,
                 txtDireccion.Text,
                 txtTelefono.Text,
                 txtCorreo.Text,
                 txtNacionalidad.Text,
                 txtOcupacion.Text,
                 txtNacimiento.Text,
                 txtSexo.Text,
                 txtEstadoCivil.Text,
                 txtSangre.Text
            );

            // Limpia los campos después de registrar
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
            }


        }

        
    }
}
