using PMBYOS.Library.Models;
using PMBYOS.Library.Utils;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcess_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();           
            principal.ShowDialog();                           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tecnicos tecnico = new Tecnicos();
            tecnico.nome = txtUser.Text;
            tecnico.senha = txtPassword.Text;

            tecnico.saveTecnicoLogin(tecnico.nome, tecnico.senha);
        }
    }
}
