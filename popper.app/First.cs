using Microsoft.Extensions.DependencyInjection;
using popper.app.Cadastros;
using popper.app.Infra;
using ReaLTaiizor.Forms;


namespace popper
{
    public partial class First : MaterialForm
    {
        public First()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }


        private void chamadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroChamado>();
        }
        private void técnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroTecnico>();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroUsuario>();
        }
        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroLocal>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }


    }
}