using Microsoft.VisualBasic;
using PMBYOS.Library.Models;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public string  userName { get; set; }
        public bool AdminPrivileges { get; set; }

        //Aviso aviso = new Aviso();


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblInfoUser.Text = userName;
            dtgAviso.Rows.Clear();
            //aviso.loadAviso(dtgAviso);
        }

        private void tsBtnOrdens_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFunc cadFunc = new frmCadFunc();
            cadFunc.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void emAndamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarOs buscarOs = new frmBuscarOs();
            buscarOs.filterBy = "Abertas";
            buscarOs.Show();


        }

        private void visualizarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPeca frm = new frmBuscarPeca();
            frm.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadForn cadForn = new frmCadForn();
            cadForn.ShowDialog();
        }

        private void cadastrarTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadTecnicos tecnico = new frmCadTecnicos();
            tecnico.ShowDialog();
        }


        private void visualizarTécnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarTecnico frm = new frmBuscarTecnico();
            frm.Show();
        }

        private void tsBtntecnicos_ButtonClick(object sender, EventArgs e)
        {
            frmBuscarTecnico frm = new frmBuscarTecnico();
            frm.Show();
        }
        private void cadastrarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEquip cadEquip = new frmCadEquip();
            cadEquip.ShowDialog();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            string data;

            data = Convert.ToString(DateAndTime.Now);

            tsLblHora.Text = data;

        }

        private void visualizarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEquip buscarEquip = new frmBuscarEquip();
            buscarEquip.Show();

        }

        private void editarEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarEquip editareEquip = new frmEditarEquip();
            editareEquip.Show();
        }

        private void finalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarOs frm = new frmBuscarOs();
            frm.filterBy = "Finalizadas";
            frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarFunc editarFunc = new frmEditarFunc();
            editarFunc.Show();

        }

        private void tsBtnFuncionarios_ButtonClick(object sender, EventArgs e)
        {
            frmBuscarFuncionario form = new frmBuscarFuncionario();
            form.Show();
        }

        private void tsBtnOrdens_ButtonClick_1(object sender, EventArgs e)
        {
            frmBuscarOs form = new frmBuscarOs();
            form.filterBy = "Abertas";
            form.Show();
        }

        private void tsBtnEquip_ButtonClick(object sender, EventArgs e)
        {
            frmBuscarEquip form = new frmBuscarEquip();
            form.Show();
        }

        private void tsBtnPecas_ButtonClick(object sender, EventArgs e)
        {
            frmBuscarPeca form = new frmBuscarPeca();
            form.Show();
        }

        private void tsBtnFornecedores_ButtonClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAviso_Click(object sender, EventArgs e)
        {
            frmAddAviso frm = new frmAddAviso();
            frm.Show();
        }

        private void tsLblHora_Click(object sender, EventArgs e)
        {

        }

        private void updateForm_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
