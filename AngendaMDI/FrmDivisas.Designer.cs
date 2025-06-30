namespace AngendaMDI
{
    partial class FrmDivisas
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
            btnConvertir = new Button();
            lblResultado = new Label();
            txtMonto = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(42, 183);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(469, 48);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Ingrese el monto a convertir";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(117, 602);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(303, 84);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(140, 712);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(176, 48);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(140, 255);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(261, 55);
            txtMonto.TabIndex = 3;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(140, 348);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(280, 56);
            cmbOrigen.TabIndex = 4;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(140, 475);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(280, 56);
            cmbDestino.TabIndex = 5;
            // 
            // FrmDivisas
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(954, 871);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtMonto);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(lblMonto);
            Name = "FrmDivisas";
            Text = "FrmDivisas";
            Load += FrmDivisas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Button btnConvertir;
        private Label lblResultado;
        private TextBox txtMonto;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
    }
}