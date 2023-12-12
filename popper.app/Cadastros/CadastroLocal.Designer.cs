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
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDesc = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(materialComboBox1);
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(48, 43);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(623, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 0;
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

        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDesc;
    }
}