using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMBYOS.Library.db.querys
{
    class QAviso
    {
        ConnectionPG connection = new ConnectionPG();
        public DataTable load()
        { 
            DataTable dt;
            NpgsqlConnection conn;
            NpgsqlCommand cmd;
            string sql;
            conn = connection.connect();
            try
            {
                conn.Open();
                dt = new DataTable();
                sql = String.Format(@"select * from avisos");
                cmd = new NpgsqlCommand(sql, conn);
                dt.Load(cmd.ExecuteReader());

                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }
        public void create(string data, string aviso)
        {
            ConnectionPG connection = new ConnectionPG();
            NpgsqlConnection conn;
            NpgsqlCommand cmd;
            string sql;

            try
            {
                conn = connection.connect();
                sql = String.Format( "INSERT INTO avisos(dataaviso, aviso) VALUES ('{0}','{1}')", data, aviso);
                conn.Open();
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o segunte erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
            conn.Close();
        }
    }

}
