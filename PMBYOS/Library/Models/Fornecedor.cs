using System.Data;
using PMBYOS.Library.db;

namespace PMBYOS.Library.Models
{
    class Fornecedor 
    {
        public long codigo { get; set; }
        public string razao { get; set; }
        public string endereco { get; set; }
        public string incricao { get; set; }
        public string cnpj { get; set; }
        public Contato Contato { get; set; }

        

       /* public DataTable select()
        {
            Connection connection = new Connection();
            //return connection.load("fornecedores");
        }

        public void insert()
        {
            Connection connection = new Connection();
            connection.create("Funcionarios", "", "");
        }
       */
    }
}
