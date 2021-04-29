using PMBYOS.Library.Models;
using PMBYOS.Library.Utils;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmCadTecnicos : Form
    {
        public frmCadTecnicos()
        {
            InitializeComponent();
        }

        string alterName;
   
        public void  formatValues(string name)
        {
            alterName = name;
        }

        private void frmCadTecnicos_Load(object sender, EventArgs e)
        {
            //Carregar o listBox para cargo
            if(alterName != "")
            {
                txtNome.Text = alterName;
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tecnicos tecnico = new Tecnicos();
            tecnico.Contato = new Contato();
            
            ItemValidations valid = new ItemValidations();
            
            tecnico.nome = txtNome.Text;
            tecnico.cargo = txtCargo.Text;
            tecnico.Contato.telefone = mtxtTelefone.Text;
            tecnico.Contato.celular = mtxtCelular.Text;
            tecnico.Contato.email = txtEmail.Text;

            // TODO criptografar senha
            tecnico.senha = txtSenha.Text;

            bool validated =  valid.validTecnicos(tecnico);

            if (!validated)
            {

            }
            else
            {
                //Cadastra no banco
            }
           
            

        }
    }
}
