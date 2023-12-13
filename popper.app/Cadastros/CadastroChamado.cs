using popper.app.Base;
using popper.domain.Base;
using popper.domain.Entities;
using popper.Service.Validators;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popper.app.Cadastros
{
    public partial class CadastroChamado : CadastroBase
    {
        private readonly IBaseService<Chamado> _chamadoService;

        private List<Chamado>? chamados;
        public CadastroChamado(IBaseService<Chamado> chamadoService)
        {
            _chamadoService = chamadoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Chamado chamado)
        {
            var nome = (Usuario)cboNome.SelectedItem;
            var tecnico = (Tecnico)cboTecnico.SelectedItem;
            chamado.Nome = nome;
            chamado.Tecnico = tecnico;
            chamado.Desc = txtDesc.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var chamado = _chamadoService.GetById<Chamado>(id);
                        PreencheObjeto(chamado);
                        chamado = _chamadoService.Update<Chamado, Chamado, ChamadoValidator>(chamado);
                    }
                }
                else
                {
                    var chamado = new Chamado();
                    PreencheObjeto(chamado);
                    _chamadoService.Add<Chamado, Chamado, ChamadoValidator>(chamado);
                }

                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Popper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _chamadoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Popper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            chamados = _chamadoService.Get<Chamado>().ToList();
            dataGridView1.DataSource = chamados;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboNome.Text = linha?.Cells["Nome"].Value.ToString();
            cboTecnico.Text = linha?.Cells["Estado"].Value.ToString();
            txtDesc.Text = linha?.Cells["Descricao"].Value.ToString();
        }
    }
}
