using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PMBYOS.Library.db.querys
{
    public class QTecnico
    {
        ConnectionPG conection = new ConnectionPG();
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        string sql;

        public DataTable load()
        {
            DataTable dt;
            NpgsqlConnection conn;
            NpgsqlCommand cmd;
            string sql;
            conn = conection.connect();
            try
            {
                conn.Open();
                dt = new DataTable();
                sql = String.Format(@"select nome, telefone, endereco, is_admin from tecnicos");
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

        public DataTable searchBy(string param, string seach)
        {
            DataTable dt;
            NpgsqlConnection conn;
            NpgsqlCommand cmd;
            string sql;
            conn = conection.connect();
            try
            {
                conn.Open();
                dt = new DataTable();
                sql = String.Format(@"select nome, telefone, endereco, is_admin from tecnicos where {0} LIKE '%{1}%'", param, seach);
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

        public void create(string user, string password)
        {

            try
            {
                conn = conection.connect();
                sql = string.Format(@"insert into tecnicos(usuario, senha) values ('{0}', '{1}')", user, password);
                conn.Open();
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public string getLogin(string user)
        {
            conn = conection.connect();
            sql = string.Format("select senha from tecnicos where usuario = '{0}'", user);
            conn.Open();
            cmd = new NpgsqlCommand(sql, conn);
            string passwordDB = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return passwordDB;
        }
    }
}
