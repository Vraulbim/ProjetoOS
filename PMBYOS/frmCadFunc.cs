using PMBYOS.Library.Models;
using PMBYOS.Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmCadFunc : Form
    {
        ItemValidations valid = new ItemValidations();
        public frmCadFunc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtboxCargo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario.Departamento = new Departamento();
            funcionario.Contato = new Contato();

            string nome = txtboxNome.Text;
            string departamento = txtboxDep.Text;
            string cargo = txtboxCargo.Text;
            string email = txtboxEmail.Text;
            string telefone = mTxtBoxTel.Text;
            string encarregado = txtBoxEncarregado.Text;

            funcionario.nome = nome;
            funcionario.Departamento.nomeDepartamento = departamento;
            funcionario.cargo = cargo;
            funcionario.Contato.email = email;
            funcionario.Contato.telefone = telefone;
            funcionario.encarregado = encarregado;

            bool validation = valid.validFunc(funcionario);

            if (validation)
            {
                //Cadastrar no banco
            }
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {

        }

        private void mTextBoxTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
