using PMBYOS.Library.Models;
using PMBYOS.Library.Utils;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmBuscarTecnico : Form
    {
        public frmBuscarTecnico()
        {
            InitializeComponent();
        }

        string param;
        Tecnicos tecnico = new Tecnicos();

        ItemValidations validations = new ItemValidations();


        private void frmBuscarTecnico_Load(object sender, EventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            dtgTecnicos.Rows.Clear();
            //tecnicos.loadTecnico(dtgTecnicos);


            //Passar para um metodo validador
            if(rbNome.Checked == true)
            {
                rbTelefone.Checked = false;
                param = "nome";
            }
            else
            {
                rbTelefone.Checked = true;
                rbNome.Checked = false;
                param = "telefone";
            }

            txtBusca.Focus();

        }

        private void btnBuscarTec_Click(object sender, EventArgs e)
        {
            

            bool validation = validations.validFilterTecnicos(txtBusca.Text);
            dtgTecnicos.Focus();
            if (validation == false){}
            else
            {    
                //tecnico.searchTecnico(dtgTecnicos, param, txtBusca.Text);
            }
            txtBusca.Clear();
          
        }

        private void dtgTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCadTecnicos cadastrar = new frmCadTecnicos();
            cadastrar.formatValues(dtgTecnicos.CurrentRow.Cells[0].Value.ToString());
            cadastrar.Show();
        }

        private void dtgTecnicos_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
                dtgTecnicos.Focus();
                //tecnico.searchTecnico(dtgTecnicos, param, TextModify.ToTittle(txtBusca.Text));
                txtBusca.Focus();
        }
    }
}
