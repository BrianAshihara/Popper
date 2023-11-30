namespace popper
{
    partial class Usuario
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
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(102, 102);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(664, 48);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AnimateReadOnly = false;
            this.txtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.HideSelection = true;
            this.txtEndereco.Hint = "Endereco";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(102, 175);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PrefixSuffixText = null;
            this.txtEndereco.ReadOnly = false;
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(664, 48);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.TrailingIcon = null;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Name = "Usuario";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
    }
}