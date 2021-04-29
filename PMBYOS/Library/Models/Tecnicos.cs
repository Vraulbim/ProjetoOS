using PMBYOS.Library.db.querys;
using PMBYOS.Library.Utils;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PMBYOS.Library.Models
{
    class Tecnicos
    { 
        public long codigo { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public string senha { get; set; }
        public Contato Contato { get; set; }

        public void saveTecnicoLogin(string user, string password)
        {
            QTecnico query = new QTecnico();
            var hash = new HashPassword(SHA512.Create());
            string cripPassword = hash.criptograpyPassword(password);
            query.create(user, cripPassword);
        }
        public bool validLogin(string user, string senha)
        {
            QTecnico query = new QTecnico();
            var hash = new HashPassword(SHA512.Create());
            string passwordDB = query.getLogin(user);
            bool valid = hash.VerificarSenha(senha, passwordDB);
            return valid;
        }
        public void loadTecnico(DataGridView dataGrid)
        {
            QTecnico query = new QTecnico();
            DataTable dt = query.load();
            foreach (DataRow item in dt.Rows)
            {
                dataGrid.Rows.Add(item.ItemArray);
            }
        }
        public void searchTecnico(DataGridView dataGrid, string param, string data)
        {
            QTecnico query = new QTecnico();
            dataGrid.Rows.Clear();
            DataTable dt = query.searchBy(param, data);

            foreach (DataRow item in dt.Rows)
            {
                dataGrid.Rows.Add(item.ItemArray);
            }
        }
    }
}
