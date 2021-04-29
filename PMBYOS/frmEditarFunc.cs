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
    public partial class frmEditarFunc : Form
    {
        public frmEditarFunc()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Contato = new Contato();
            funcionarios.Departamento = new Departamento();


            ItemValidations itemValidations = new ItemValidations();
            bool validacao = itemValidations.validFunc(funcionarios);
            if (validacao == true)
            {
                
            }
            else
            {

            }
            
            
            


                
        }
    }
}
