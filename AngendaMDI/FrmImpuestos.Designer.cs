namespace AngendaMDI
{
    partial class FrmImpuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblTipolmpuesto = new Label();
            cmbImpuesto = new ComboBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(32, 44);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(290, 48);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Ingrese el monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(18, 165);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(259, 55);
            txtMonto.TabIndex = 1;
            // 
            // lblTipolmpuesto
            // 
            lblTipolmpuesto.AutoSize = true;
            lblTipolmpuesto.Location = new Point(25, 295);
            lblTipolmpuesto.Name = "lblTipolmpuesto";
            lblTipolmpuesto.Size = new Size(509, 48);
            lblTipolmpuesto.TabIndex = 2;
            lblTipolmpuesto.Text = "Seleccione el tipo de Impuesto";
            // 
            // cmbImpuesto
            // 
            cmbImpuesto.FormattingEnabled = true;
            cmbImpuesto.Location = new Point(5, 386);
            cmbImpuesto.Name = "cmbImpuesto";
            cmbImpuesto.Size = new Size(307, 56);
            cmbImpuesto.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(10, 734);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(321, 48);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Total con impuesto";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(19, 560);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(281, 84);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FrmImpuestos
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(926, 967);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(cmbImpuesto);
            Controls.Add(lblTipolmpuesto);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Name = "FrmImpuestos";
            Text = "FrmImpuestos";
            Load += FrmImpuestos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblTipolmpuesto;
        private ComboBox cmbImpuesto;
        private Label lblResultado;
        private Button btnCalcular;
    }
}