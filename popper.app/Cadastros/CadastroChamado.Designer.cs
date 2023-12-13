namespace popper.app.Cadastros
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
            cboTecnico = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDesc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboNome = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Size = new Size(794, 383);
            // 
            // tabPage1
            // 
            tabPage1.Size = new Size(786, 355);
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(cboTipo);
            panel1.Controls.Add(cboTecnico);
            panel1.Controls.Add(cboNome);
            // 
            // cboTecnico
            // 
            cboTecnico.AutoResize = false;
            cboTecnico.BackColor = Color.FromArgb(255, 255, 255);
            cboTecnico.Depth = 0;
            cboTecnico.DrawMode = DrawMode.OwnerDrawVariable;
            cboTecnico.DropDownHeight = 174;
            cboTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTecnico.DropDownWidth = 121;
            cboTecnico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTecnico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTecnico.FormattingEnabled = true;
            cboTecnico.Hint = "Quem realizará o atendimento";
            cboTecnico.IntegralHeight = false;
            cboTecnico.ItemHeight = 43;
            cboTecnico.Location = new Point(56, 102);
            cboTecnico.MaxDropDownItems = 4;
            cboTecnico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTecnico.Name = "cboTecnico";
            cboTecnico.Size = new Size(625, 49);
            cboTecnico.StartIndex = 0;
            cboTecnico.TabIndex = 12;
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
            cboTipo.Hint = "Qual o tipo de problema";
            cboTipo.IntegralHeight = false;
            cboTipo.ItemHeight = 43;
            cboTipo.Location = new Point(399, 23);
            cboTipo.MaxDropDownItems = 4;
            cboTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(282, 49);
            cboTipo.StartIndex = 0;
            cboTipo.TabIndex = 13;
            // 
            // txtDesc
            // 
            txtDesc.AnimateReadOnly = false;
            txtDesc.AutoCompleteMode = AutoCompleteMode.None;
            txtDesc.AutoCompleteSource = AutoCompleteSource.None;
            txtDesc.BackgroundImageLayout = ImageLayout.None;
            txtDesc.CharacterCasing = CharacterCasing.Normal;
            txtDesc.Depth = 0;
            txtDesc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDesc.HideSelection = true;
            txtDesc.Hint = "Descricao do problema";
            txtDesc.LeadingIcon = null;
            txtDesc.Location = new Point(56, 176);
            txtDesc.MaxLength = 32767;
            txtDesc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDesc.Name = "txtDesc";
            txtDesc.PasswordChar = '\0';
            txtDesc.PrefixSuffixText = null;
            txtDesc.ReadOnly = false;
            txtDesc.RightToLeft = RightToLeft.No;
            txtDesc.SelectedText = "";
            txtDesc.SelectionLength = 0;
            txtDesc.SelectionStart = 0;
            txtDesc.ShortcutsEnabled = true;
            txtDesc.Size = new Size(623, 48);
            txtDesc.TabIndex = 14;
            txtDesc.TabStop = false;
            txtDesc.TextAlign = HorizontalAlignment.Left;
            txtDesc.TrailingIcon = null;
            txtDesc.UseSystemPasswordChar = false;
            // 
            // cboNome
            // 
            cboNome.AutoResize = false;
            cboNome.BackColor = Color.FromArgb(255, 255, 255);
            cboNome.Depth = 0;
            cboNome.DrawMode = DrawMode.OwnerDrawVariable;
            cboNome.DropDownHeight = 174;
            cboNome.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNome.DropDownWidth = 121;
            cboNome.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNome.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNome.FormattingEnabled = true;
            cboNome.Hint = "Quem realizou o chamado";
            cboNome.IntegralHeight = false;
            cboNome.ItemHeight = 43;
            cboNome.Location = new Point(56, 23);
            cboNome.MaxDropDownItems = 4;
            cboNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNome.Name = "cboNome";
            cboNome.Size = new Size(282, 49);
            cboNome.StartIndex = 0;
            cboNome.TabIndex = 11;
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
            txtId.Location = new Point(56, 240);
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
            txtId.Size = new Size(623, 48);
            txtId.TabIndex = 15;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroChamado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Chamado";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cboTecnico;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDesc;
        private ReaLTaiizor.Controls.MaterialComboBox cboNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}