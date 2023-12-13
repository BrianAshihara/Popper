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
    public partial class CadastroLocal : CadastroBase
    {
        private readonly IBaseService<Local> _localService;
        private readonly IBaseService<Usuario> _usuarioService;

        private List<Local>? locais;
        public CadastroLocal(IBaseService<Local> localService,IBaseService<Usuario> usuarioService)
        {
            _localService = localService;
            _usuarioService = usuarioService;
            InitializeComponent();
            CarregarCombo();
            
        }
        private void CarregarCombo()
        {
            cboNome.ValueMember = "Id";
            cboNome.DisplayMember = "Nome";
            cboNome.DataSource = _usuarioService.Get<Usuario>().ToList();

        }
        private void PreencheObjeto(Local local)
        {
            var nome = (Usuario)cboNome.SelectedItem;
            local.Nome = nome;
            local.Localdesc = txtDesc.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var local = _localService.GetById<Local>(id);
                        PreencheObjeto(local);
                        local = _localService.Update<Local, Local, LocalValidator>(local);
                    }
                }
                else
                {
                    var local = new Local();
                    PreencheObjeto(local);
                    _localService.Add<Local, Local, LocalValidator>(local);
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
                _localService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Popper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            locais = _localService.Get<Local>().ToList();
            dataGridView1.DataSource = locais;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDesc.Text = linha?.Cells["Descricao"].Value.ToString();
        }
    }
}
