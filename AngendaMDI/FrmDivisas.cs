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
    public partial class FrmDivisas : Form
    {
        public FrmDivisas()
        {
            InitializeComponent();
        }

        private void FrmDivisas_Load(object sender, EventArgs e)
        {
            cmbOrigen.Items.AddRange(new string[] { "USD", "EUR", "DOP" });
            cmbDestino.Items.AddRange(new string[] { "USD", "EUR", "DOP" });

            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;


        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                string origen = cmbOrigen.SelectedItem.ToString();
                string destino = cmbDestino.SelectedItem.ToString();
                double tasa = ObtenerTasaCambio(origen, destino);
                double resultado = monto * tasa;

                lblResultado.Text = $"Resultado: {resultado:N2} {destino}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private double ObtenerTasaCambio(string origen, string destino)
        {
            if (origen == destino)
                return 1.0;

            if (origen == "USD" && destino == "DOP") return 58.5;
            if (origen == "DOP" && destino == "USD") return 0.017;

            if (origen == "EUR" && destino == "DOP") return 63.2;
            if (origen == "DOP" && destino == "EUR") return 0.016;

            if (origen == "USD" && destino == "EUR") return 0.93;
            if (origen == "EUR" && destino == "USD") return 1.07;

            return 1.0;
        }


    }
}
