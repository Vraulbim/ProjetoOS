using PMBYOS.Library.Models;
using PMBYOS.Library.Utils;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmCadForn : Form
    {
        public frmCadForn()
        {
            InitializeComponent();
        }

        ItemValidations valid = new ItemValidations();

        private void frmCadForn_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Contato = new Contato();


            fornecedor.razao = txtBoxRazao.Text;
            if(txtBoxEndereco.Text != "" && txtBoxNum.Text != "" && txtBoxBairro.Text != "")
            {
                fornecedor.endereco = (txtBoxEndereco.Text + " ," + txtBoxBairro.Text + " nº " + txtBoxNum.Text);
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos de endereço", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fornecedor.cnpj = mTxtBoxCNPJ.Text;
            fornecedor.incricao = txtBoxInscricao.Text;
            fornecedor.Contato.email = txtBoxEmail.Text;
            fornecedor.Contato.telefone = mTxtBoxTel.Text;
            fornecedor.Contato.celular = mTxtBoxCel.Text;

            bool validation = valid.validForn(fornecedor);

            if(validation)
            {
               
            }
        }

        private void txtBoxRazao_TextChanged(object sender, EventArgs e)
        {


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}
