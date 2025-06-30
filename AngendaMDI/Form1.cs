namespace AngendaMDI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void formularioDelRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.MdiParent = this;
            registro.Show();


        }

        private void calculadoraDeIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivisas ventana = new FrmDivisas();
            ventana.Show();

        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImpuestos ventana = new FrmImpuestos();
            ventana.Show();


        }

        private void limiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFibonacci ventana = new FrmFibonacci();
            ventana.Show();


        }
    }

}
