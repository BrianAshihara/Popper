using popper.app.Base;
using popper.domain.Base;
using popper.domain.Entities;
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

        private List<Chamado>? chamado;
        public CadastroChamado(IBaseService<Chamado> chamadoService)
        {
            _chamadoService = chamadoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Chamado chamado)
        {
            var nome = (Usuario) cboNome.SelectedItem; 
            var tecnico = (Tecnico) cboTecnico.SelectedItem;
            chamado.Nome = nome;
            chamado.Tecnico = tecnico;
            chamado.Desc = txtDesc.Text;
        }
    }
}
