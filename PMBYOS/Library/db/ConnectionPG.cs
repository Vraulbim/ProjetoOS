using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMBYOS.Library.db
{
     public class ConnectionPG
    {
        private string connection = String.Format("Server={0};Port={1};" +
                     "User Id={2};Password={3};Database={4}",
                     "192.168.1.31", 5432,
                     "pmbyos", "pmbyos2021", "postgres");

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;


        //singleton DP
        public NpgsqlConnection connect()
        {
            return new NpgsqlConnection(connection);
        }

        public void create(string table, string colums, string values)
        {
            conn = new NpgsqlConnection(connection);

            try
            {
                conn.Open();
                sql = String.Format(@"insert into {0} ({1}) values ({2})", table, colums, values);
                cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastrado com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro durante o cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
