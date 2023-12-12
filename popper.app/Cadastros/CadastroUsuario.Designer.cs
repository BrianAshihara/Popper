namespace popper.app.Cadastros
{
    partial class CadastroUsuario
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCpf = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(127, 33);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(514, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            txtCpf.AnimateReadOnly = false;
            txtCpf.AutoCompleteMode = AutoCompleteMode.None;
            txtCpf.AutoCompleteSource = AutoCompleteSource.None;
            txtCpf.BackgroundImageLayout = ImageLayout.None;
            txtCpf.CharacterCasing = CharacterCasing.Normal;
            txtCpf.Depth = 0;
            txtCpf.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCpf.HideSelection = true;
            txtCpf.Hint = "CPF";
            txtCpf.LeadingIcon = null;
            txtCpf.Location = new Point(127, 115);
            txtCpf.MaxLength = 32767;
            txtCpf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCpf.Name = "txtCpf";
            txtCpf.PasswordChar = '\0';
            txtCpf.PrefixSuffixText = null;
            txtCpf.ReadOnly = false;
            txtCpf.RightToLeft = RightToLeft.No;
            txtCpf.SelectedText = "";
            txtCpf.SelectionLength = 0;
            txtCpf.SelectionStart = 0;
            txtCpf.ShortcutsEnabled = true;
            txtCpf.Size = new Size(514, 48);
            txtCpf.TabIndex = 1;
            txtCpf.TabStop = false;
            txtCpf.TextAlign = HorizontalAlignment.Left;
            txtCpf.TrailingIcon = null;
            txtCpf.UseSystemPasswordChar = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "CadastroUsuario";
            Text = "Cadastro Usuario";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCpf;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}