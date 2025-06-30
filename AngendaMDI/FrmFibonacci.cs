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
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (int.TryParse(txtLimite.Text, out int limite) && limite >= 0)
            {
                int a = 0, b = 1;

                txtResultado.AppendText($"{a}");

                while (b <= limite)
                {
                    txtResultado.AppendText($", {b}");
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
