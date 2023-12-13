using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popper.app.Base
{
    public partial class CadastroBase : MaterialForm
    {
        protected bool IsAlteracao = false;

        public CadastroBase()
        {
            InitializeComponent();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"Popper", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"Popper", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Popper", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }



        #region CRUD Methods
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in panel1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();

                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            tabControl1.SelectedIndex = 0;
            tabPage1.Focus();
        }
        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                CarregaRegistro(linha);
                tabControl1.SelectedIndex = 0;
                tabPage1.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Popper", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }
        #endregion

    }
}
