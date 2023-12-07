using Microsoft.Extensions.DependencyInjection;
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

        private void chamadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void técnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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