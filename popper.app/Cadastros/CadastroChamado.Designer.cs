namespace popper
{
    partial class CadastroChamado
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
            this.txtDesc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtHora = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboNome = new ReaLTaiizor.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.AnimateReadOnly = false;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesc.Depth = 0;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesc.HideSelection = true;
            this.txtDesc.Hint = "Descricao";
            this.txtDesc.LeadingIcon = null;
            this.txtDesc.Location = new System.Drawing.Point(116, 158);
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
            this.txtDesc.Size = new System.Drawing.Size(632, 48);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.TabStop = false;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TrailingIcon = null;
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // txtHora
            // 
            this.txtHora.AnimateReadOnly = false;
            this.txtHora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHora.Depth = 0;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHora.HideSelection = true;
            this.txtHora.Hint = "Quando ocorreu?";
            this.txtHora.LeadingIcon = null;
            this.txtHora.Location = new System.Drawing.Point(116, 226);
            this.txtHora.MaxLength = 32767;
            this.txtHora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.PrefixSuffixText = null;
            this.txtHora.ReadOnly = false;
            this.txtHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHora.SelectedText = "";
            this.txtHora.SelectionLength = 0;
            this.txtHora.SelectionStart = 0;
            this.txtHora.ShortcutsEnabled = true;
            this.txtHora.Size = new System.Drawing.Size(632, 48);
            this.txtHora.TabIndex = 1;
            this.txtHora.TabStop = false;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHora.TrailingIcon = null;
            this.txtHora.UseSystemPasswordChar = false;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoResize = false;
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStatus.Depth = 0;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboStatus.DropDownHeight = 174;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 121;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Hint = "Status";
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.ItemHeight = 43;
            this.cboStatus.Items.AddRange(new object[] {
            "Nao resolvido",
            "Resolvido"});
            this.cboStatus.Location = new System.Drawing.Point(116, 296);
            this.cboStatus.MaxDropDownItems = 4;
            this.cboStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(250, 49);
            this.cboStatus.StartIndex = 0;
            this.cboStatus.TabIndex = 3;
            // 
            // cboTipo
            // 
            this.cboTipo.AutoResize = false;
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTipo.Depth = 0;
            this.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipo.DropDownHeight = 174;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DropDownWidth = 121;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Hint = "Tipo do Problema";
            this.cboTipo.IntegralHeight = false;
            this.cboTipo.ItemHeight = 43;
            this.cboTipo.Items.AddRange(new object[] {
            "",
            "Mecanico",
            "Eletrico",
            "Assistencia"});
            this.cboTipo.Location = new System.Drawing.Point(396, 296);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(352, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(543, 364);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 6;
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
            this.btnSalvar.Location = new System.Drawing.Point(672, 364);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(76, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
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
            this.cboNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Hint = "Quem esta com problema?";
            this.cboNome.IntegralHeight = false;
            this.cboNome.ItemHeight = 43;
            this.cboNome.Location = new System.Drawing.Point(116, 84);
            this.cboNome.MaxDropDownItems = 4;
            this.cboNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(632, 49);
            this.cboNome.StartIndex = 0;
            this.cboNome.TabIndex = 8;
            // 
            // CadastroChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDesc);
            this.Name = "CadastroChamado";
            this.Text = "Cadastrar Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDesc;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHora;
        private ReaLTaiizor.Controls.MaterialComboBox cboStatus;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialComboBox cboNome;
    }
}