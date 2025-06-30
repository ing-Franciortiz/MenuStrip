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
    public partial class FrmImpuestos : Form
    {
        public FrmImpuestos()
        {
            InitializeComponent();
        }

        private void FrmImpuestos_Load(object sender, EventArgs e)
        {
            cmbImpuesto.Items.Add("ITBIS 18%");
            cmbImpuesto.Items.Add("IVA 16%");
            cmbImpuesto.Items.Add("Impuesto Selectivo 10%");
            cmbImpuesto.SelectedIndex = 0;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                double porcentaje = ObtenerPorcentajeImpuesto(cmbImpuesto.SelectedItem.ToString());
                double impuesto = monto * porcentaje;
                double total = monto + impuesto;

                lblResultado.Text = $"Monto: {monto:N2}\nImpuesto: {impuesto:N2}\nTotal con impuesto: {total:N2}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        private double ObtenerPorcentajeImpuesto(string tipo)
        {
            if (tipo.Contains("18%")) return 0.18;
            if (tipo.Contains("16%")) return 0.16;
            if (tipo.Contains("10%")) return 0.10;

            return 0;
        }


    }
}
