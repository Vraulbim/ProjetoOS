using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmBuscarPeca : Form
    {
        public frmBuscarPeca()
        {
            InitializeComponent();
        }

        private void frmBuscarPeca_Load(object sender, EventArgs e)
        {
            string value;

            if(rbDescricao.Checked == true)
            {
                rbFornecedor.Checked = false;
                rbGrupo.Checked = false;
                value = "Descricao";
            }else if(rbFornecedor.Checked == true)
            {
                rbDescricao.Checked = false;
                rbGrupo.Checked = false;
                value = "Fornecedor";
            }
            else if(rbGrupo.Checked == true)
            {
                rbFornecedor.Checked = false;
                rbDescricao.Checked = false;
                value = "Grupo";
            }
            else
            {
                MessageBox.Show("É necessário marcar uma opção de busca", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string busca = txtPeca.Text;

            if (busca == "")
            {
                MessageBox.Show("É necessário preencher o campo de busca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nbQtd.Value == 0)
            { 

                MessageBox.Show("O valor da quantidade não pode ser igual a 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // TODO Buscar no banco com base no value
            }
        }
    }
}