namespace popper
{
    partial class First
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chamadoToolStripMenuItem
            // 
            this.chamadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadoToolStripMenuItem1,
            this.técnicosToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.chamadoToolStripMenuItem.Name = "chamadoToolStripMenuItem";
            this.chamadoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.chamadoToolStripMenuItem.Text = "Opções";
            // 
            // chamadoToolStripMenuItem1
            // 
            this.chamadoToolStripMenuItem1.Name = "chamadoToolStripMenuItem1";
            this.chamadoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chamadoToolStripMenuItem1.Text = "Chamado";
            this.chamadoToolStripMenuItem1.Click += new System.EventHandler(this.chamadoToolStripMenuItem1_Click);
            // 
            // técnicosToolStripMenuItem
            // 
            this.técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            this.técnicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.técnicosToolStripMenuItem.Text = "Técnicos";
            this.técnicosToolStripMenuItem.Click += new System.EventHandler(this.técnicosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.localToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.localToolStripMenuItem.Text = "Local";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "First";
            this.Text = "Central de Chamados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chamadoToolStripMenuItem;
        private ToolStripMenuItem chamadoToolStripMenuItem1;
        private ToolStripMenuItem técnicosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem;
    }
}