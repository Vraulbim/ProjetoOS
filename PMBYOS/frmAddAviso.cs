using Microsoft.VisualBasic;
using Npgsql;
using PMBYOS.Library.db;
using PMBYOS.Library.Models;
using PMBYOS.Library.Utils;
using System;
using System.Windows.Forms;

namespace PMBYOS
{
    public partial class frmAddAviso : Form
    {
        public frmAddAviso()
        {
            InitializeComponent();
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aviso aviso = new Aviso();
            aviso.content = txtAviso.Text;
            aviso.date = Convert.ToString(DateAndTime.Today.ToString("dd/MM/yyyy "));

            aviso.saveAviso(aviso.date, aviso.content);
            this.Close();
        }
    }
}
