using PMBYOS.Library.Utils;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmBuscarEquip : Form
    {
        public frmBuscarEquip()
        {
            InitializeComponent();
        }

        private void lBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBuscarEquip_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string buscar = txtBoxBuscar.Text;
            ItemValidations validacao = new ItemValidations();
            bool valid = validacao.validBusca(buscar);
            if (valid == false)
            {
                
            }
            else
            {
                //conexão com o banco
            }
        }
    }
}
