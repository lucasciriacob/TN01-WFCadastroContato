namespace TN01_WFCadastroContato
{
    partial class FormMain
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
            mnsCadastrar = new ToolStripMenuItem();
            mnsSobre = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsSobre, mnsSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(276, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsSobre
            // 
            mnsSobre.Name = "mnsSobre";
            mnsSobre.Size = new Size(49, 20);
            mnsSobre.Text = "Sobre";
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.projeto2;
            pictureBox1.Location = new Point(2, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 208);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "FormMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsSobre;
        private ToolStripMenuItem mnsSair;
        private PictureBox pictureBox1;
        private ToolStripMenuItem mnsCadastrar;
    }
}
