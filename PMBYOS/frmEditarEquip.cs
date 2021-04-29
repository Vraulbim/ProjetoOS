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
    public partial class frmEditarEquip : Form
    {
        public frmEditarEquip()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEditarEquip_Load(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {

            

            string buscar = txtBoxBuscarEq.Text;
            ItemValidations validations = new ItemValidations();
            bool validacao = validations.validBusca(buscar);

            if (validacao == false)
            {
                
            }
            else
            {
                // conexão com o banco
            }

        }

        private void txtBoxBuscarEq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
