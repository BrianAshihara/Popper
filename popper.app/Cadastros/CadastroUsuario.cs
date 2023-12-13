using popper.app.Base;
using popper.app.Models;
using popper.domain.Base;
using popper.domain.Entities;
using popper.Service.Validators;


namespace popper.app.Cadastros
{
    public partial class CadastroUsuario : CadastroBase
    {
        private readonly IBaseService<Usuario> _usuarioService;

        private List<Usuario>? usuarios;
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        private void PreencheObjeto(Usuario usuario)
        {

            usuario.Nome = txtNome.Text;
            usuario.Cpf = txtCpf.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
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
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Popper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<Usuario>().ToList();

            dataGridView1.DataSource = usuarios;
            dataGridView1.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCpf.Text = linha?.Cells["CPF"].Value.ToString();
        }
    }
}
