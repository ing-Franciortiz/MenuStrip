namespace AngendaMDI
{
    partial class FrmFibonacci
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
            btnGenerar = new Button();
            lblLimite = new Label();
            txtLimite = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(24, 326);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(239, 61);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar Serie";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Location = new Point(24, 61);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(273, 48);
            lblLimite.TabIndex = 1;
            lblLimite.Text = "Ingresa el limite";
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(28, 190);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(228, 55);
            txtLimite.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 488);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(493, 184);
            txtResultado.TabIndex = 3;
            // 
            // FrmFibonacci
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(517, 684);
            Controls.Add(txtResultado);
            Controls.Add(txtLimite);
            Controls.Add(lblLimite);
            Controls.Add(btnGenerar);
            Name = "FrmFibonacci";
            Text = "FrmFibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Label lblLimite;
        private TextBox txtLimite;
        private TextBox txtResultado;
    }
}