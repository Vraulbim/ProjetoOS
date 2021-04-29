using PMBYOS.Library.db;
using PMBYOS.Library.db.querys;
using System.Data;
using System.Windows.Forms;

namespace PMBYOS.Library.Models
{
    class Aviso
    {
        ConnectionPG connection = new ConnectionPG();
        QAviso querys = new QAviso();

        public string  content { get; set; }
        public string  date { get; set; }
        public void loadAviso(DataGridView dataGrid)
        {
            DataTable dt = querys.load();
            foreach (DataRow item in dt.Rows)
            {
                dataGrid.Rows.Add(item.ItemArray);
            }
        }
        public void saveAviso(string data, string aviso)
        {
            querys.create(data, aviso);
        }
    }
}
