using popper.app.Base;
using popper.domain.Base;
using popper.domain.Entities;
using popper.Service.Validators;
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
    public partial class CadastroTecnico : CadastroBase
    {
        private readonly IBaseService<Tecnico> _tecnicoService;

        private List<Tecnico>? tecnicos;
        public CadastroTecnico(IBaseService<Tecnico> tecnicoService)
        {
            _tecnicoService = tecnicoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Tecnico tecnico)
        {
            tecnico.Nome = txtNome.Text;
            tecnico.Endereco = txtEndereco.Text;
            tecnico.TipoEspecialidade = cboTipo.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var tecnico = _tecnicoService.GetById<Tecnico>(id);
                        PreencheObjeto(tecnico);
                        tecnico = _tecnicoService.Update<Tecnico, Tecnico, TecnicoValidator>(tecnico);
                    }
                }
                else
                {
                    var tecnico = new Tecnico();
                    PreencheObjeto(tecnico);
                    _tecnicoService.Add<Tecnico, Tecnico, TecnicoValidator>(tecnico);
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
                _tecnicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Popper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            tecnicos = _tecnicoService.Get<Tecnico>().ToList();
            dataGridView1.DataSource = tecnicos;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            cboTipo.Text = linha?.Cells["TipoEspecialidade"].Value.ToString();
        }
    }
}
