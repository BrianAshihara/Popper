namespace popper.app.Cadastros
{
    partial class CadastroTecnico
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
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(cboTipo);
            panel1.Controls.Add(txtEndereco);
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
            txtNome.Location = new Point(93, 23);
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
            txtNome.Size = new Size(579, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereco";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(93, 93);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(579, 48);
            txtEndereco.TabIndex = 1;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // cboTipo
            // 
            cboTipo.AutoResize = false;
            cboTipo.BackColor = Color.FromArgb(255, 255, 255);
            cboTipo.Depth = 0;
            cboTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipo.DropDownHeight = 174;
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.DropDownWidth = 121;
            cboTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Hint = "Tipo de Especialidade";
            cboTipo.IntegralHeight = false;
            cboTipo.ItemHeight = 43;
            cboTipo.Items.AddRange(new object[] { "", "Mecanica", "Eletrica", "Assistencia" });
            cboTipo.Location = new Point(93, 167);
            cboTipo.MaxDropDownItems = 4;
            cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(579, 49);
            cboTipo.StartIndex = 0;
            cboTipo.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(93, 235);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(579, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroTecnico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "CadastroTecnico";
            Text = "Cadastro Tecnico";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}