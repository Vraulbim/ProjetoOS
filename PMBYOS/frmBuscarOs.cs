using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmBuscarOs : Form
    {
        public string filterBy { get; set; }
        string param;
        public frmBuscarOs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBuscarOs_Load(object sender, EventArgs e)
        {
            if (rbRequisitante.Checked == true)
            {
                rbData.Checked = false;
                rbTecnico.Checked = false;
                param = "requisitante";
            }
            if (rbData.Checked == true)
            {
                rbRequisitante.Checked = false;
                rbTecnico.Checked = false;
                param = "data";
            }
            else
            {
                rbTecnico.Checked = true;
                rbData.Checked = false;
                rbRequisitante.Checked = false;
                param = "tecnico";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //SELECT no banco, com base no radio button e no txtBuscar
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Um problema foi detectado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
