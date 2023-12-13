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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            menuStrip1 = new MenuStrip();
            chamadoToolStripMenuItem = new ToolStripMenuItem();
            chamadoToolStripMenuItem1 = new ToolStripMenuItem();
            técnicosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            localToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chamadoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chamadoToolStripMenuItem
            // 
            chamadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chamadoToolStripMenuItem1, técnicosToolStripMenuItem, clienteToolStripMenuItem });
            chamadoToolStripMenuItem.Name = "chamadoToolStripMenuItem";
            chamadoToolStripMenuItem.Size = new Size(59, 20);
            chamadoToolStripMenuItem.Text = "Opções";
            // 
            // chamadoToolStripMenuItem1
            // 
            chamadoToolStripMenuItem1.Name = "chamadoToolStripMenuItem1";
            chamadoToolStripMenuItem1.Size = new Size(180, 22);
            chamadoToolStripMenuItem1.Text = "Chamado";
            chamadoToolStripMenuItem1.Click += chamadoToolStripMenuItem1_Click;
            // 
            // técnicosToolStripMenuItem
            // 
            técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            técnicosToolStripMenuItem.Size = new Size(180, 22);
            técnicosToolStripMenuItem.Text = "Técnicos";
            técnicosToolStripMenuItem.Click += técnicosToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, localToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(121, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // localToolStripMenuItem
            // 
            localToolStripMenuItem.Name = "localToolStripMenuItem";
            localToolStripMenuItem.Size = new Size(121, 22);
            localToolStripMenuItem.Text = "Local";
            localToolStripMenuItem.Click += localToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // First
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "First";
            Text = "Central de Chamados";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chamadoToolStripMenuItem;
        private ToolStripMenuItem chamadoToolStripMenuItem1;
        private ToolStripMenuItem técnicosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}