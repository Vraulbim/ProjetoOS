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
    public partial class frmCadEquip : Form
    {
        public frmCadEquip()
        {
            InitializeComponent();
        }

        ItemValidations validacao = new ItemValidations();

        private void lblSerie_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Equipamento equipamento = new Equipamento();
            equipamento.Grupo = new Grupo();
            equipamento.Local = new Local();
            equipamento.Departamento = new Departamento();
            equipamento.Fornecedor = new Fornecedor();

            equipamento.Grupo.nome = txtBoxGrupo.Text;
            equipamento.Grupo.nome_sub = txtBoxSubGrupo.Text;
            equipamento.Grupo.nome_sub = txtBoxSubGrupo.Text;
            equipamento.serie = txtBoxNSerie.Text;
            equipamento.patRelacionado = txtBoxPatri.Text;
            equipamento.Fornecedor.razao = txtBoxForn.Text;
            equipamento.dataAquisicao = mTxtBoxData.Text;
            equipamento.garantia = txtBoxGarantia.Text;
            equipamento.Departamento.nomeDepartamento = txtDepartamento.Text;
            equipamento.Local.nome = txtLocal.Text;
            equipamento.descricao = txtObservacao.Text;

            bool valid = validacao.validEquip(equipamento);
            if(valid)
            {
               
            }
        }

        private void frmCadEquip_Load(object sender, EventArgs e)
        {

        }
    }
}
