namespace popper.app.Cadastros
{
    partial class CadastroLocal
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
            this.cboNome = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtDesc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cboNome
            // 
            this.cboNome.AutoResize = false;
            this.cboNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboNome.Depth = 0;
            this.cboNome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNome.DropDownHeight = 174;
            this.cboNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNome.DropDownWidth = 121;
            this.cboNome.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Hint = "De quem é o local?";
            this.cboNome.IntegralHeight = false;
            this.cboNome.ItemHeight = 43;
            this.cboNome.Location = new System.Drawing.Point(78, 97);
            this.cboNome.MaxDropDownItems = 4;
            this.cboNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(609, 49);
            this.cboNome.StartIndex = 0;
            this.cboNome.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.AnimateReadOnly = false;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesc.Depth = 0;
            this.txtDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesc.HideSelection = true;
            this.txtDesc.Hint = "Descricao";
            this.txtDesc.LeadingIcon = null;
            this.txtDesc.Location = new System.Drawing.Point(78, 189);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PrefixSuffixText = null;
            this.txtDesc.ReadOnly = false;
            this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(609, 48);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.TabStop = false;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TrailingIcon = null;
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(490, 314);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(611, 314);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(76, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // CadastrarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cboNome);
            this.Name = "CadastrarLocal";
            this.Text = "Local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDesc;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
    }
}