namespace AngendaMDI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            registroToolStripMenuItem = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem = new ToolStripMenuItem();
            calculadoraDeIMCToolStripMenuItem = new ToolStripMenuItem();
            impuestoToolStripMenuItem = new ToolStripMenuItem();
            tToolStripMenuItem = new ToolStripMenuItem();
            formularioDelRegistroToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            fibonacciToolStripMenuItem = new ToolStripMenuItem();
            limiteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(48, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroToolStripMenuItem, formularioDelRegistroToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(917, 61);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conversorDeDivisasToolStripMenuItem, impuestoToolStripMenuItem, fibonacciToolStripMenuItem });
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(179, 57);
            registroToolStripMenuItem.Text = "Registro";
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            conversorDeDivisasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraDeIMCToolStripMenuItem });
            conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            conversorDeDivisasToolStripMenuItem.Size = new Size(547, 66);
            conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            // 
            // calculadoraDeIMCToolStripMenuItem
            // 
            calculadoraDeIMCToolStripMenuItem.Name = "calculadoraDeIMCToolStripMenuItem";
            calculadoraDeIMCToolStripMenuItem.Size = new Size(528, 66);
            calculadoraDeIMCToolStripMenuItem.Text = "Calculadora de IMC";
            calculadoraDeIMCToolStripMenuItem.Click += calculadoraDeIMCToolStripMenuItem_Click;
            // 
            // impuestoToolStripMenuItem
            // 
            impuestoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tToolStripMenuItem });
            impuestoToolStripMenuItem.Name = "impuestoToolStripMenuItem";
            impuestoToolStripMenuItem.Size = new Size(547, 66);
            impuestoToolStripMenuItem.Text = "Impuesto";
            // 
            // tToolStripMenuItem
            // 
            tToolStripMenuItem.Name = "tToolStripMenuItem";
            tToolStripMenuItem.Size = new Size(538, 66);
            tToolStripMenuItem.Text = "Calcular Total";
            tToolStripMenuItem.Click += tToolStripMenuItem_Click;
            // 
            // formularioDelRegistroToolStripMenuItem
            // 
            formularioDelRegistroToolStripMenuItem.Name = "formularioDelRegistroToolStripMenuItem";
            formularioDelRegistroToolStripMenuItem.Size = new Size(421, 57);
            formularioDelRegistroToolStripMenuItem.Text = "Formulario del Registro";
            formularioDelRegistroToolStripMenuItem.Click += formularioDelRegistroToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(28, 57);
            // 
            // fibonacciToolStripMenuItem
            // 
            fibonacciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limiteToolStripMenuItem });
            fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            fibonacciToolStripMenuItem.Size = new Size(547, 66);
            fibonacciToolStripMenuItem.Text = "Fibonacci";
            // 
            // limiteToolStripMenuItem
            // 
            limiteToolStripMenuItem.Name = "limiteToolStripMenuItem";
            limiteToolStripMenuItem.Size = new Size(538, 66);
            limiteToolStripMenuItem.Text = "Limite";
            limiteToolStripMenuItem.Click += limiteToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem formularioDelRegistroToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private ToolStripMenuItem calculadoraDeIMCToolStripMenuItem;
        private ToolStripMenuItem impuestoToolStripMenuItem;
        private ToolStripMenuItem tToolStripMenuItem;
        private ToolStripMenuItem fibonacciToolStripMenuItem;
        private ToolStripMenuItem limiteToolStripMenuItem;
    }
}
