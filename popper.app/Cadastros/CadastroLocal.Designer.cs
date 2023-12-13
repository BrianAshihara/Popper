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
            cboNome = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDesc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(cboNome);
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
            cboNome.Hint = "Nome do usuario";
            cboNome.IntegralHeight = false;
            cboNome.ItemHeight = 43;
            cboNome.Location = new Point(48, 43);
            cboNome.MaxDropDownItems = 4;
            cboNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNome.Name = "cboNome";
            cboNome.Size = new Size(623, 49);
            cboNome.StartIndex = 0;
            cboNome.TabIndex = 0;
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
            txtDesc.Hint = "Descrição do local";
            txtDesc.LeadingIcon = null;
            txtDesc.Location = new Point(48, 139);
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
            txtDesc.TabIndex = 1;
            txtDesc.TabStop = false;
            txtDesc.TextAlign = HorizontalAlignment.Left;
            txtDesc.TrailingIcon = null;
            txtDesc.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(48, 213);
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
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroLocal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "CadastroLocal";
            Text = "Cadastro Local";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDesc;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}