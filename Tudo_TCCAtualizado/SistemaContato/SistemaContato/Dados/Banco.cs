using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaContato
{
    public class Banco
    {
        //public static string conexao = (@"Password=12345;Persist Security Info=True;User ID=sa;Initial Catalog=Mauricio;Data Source=LAPTOP-P5TJIN1S\SQLEXPRESS14");
        public static string conexao = ("Password=200599;Persist Security Info=True;User ID = mauricio; Initial Catalog = Mauricio; Data Source = 10.101.148.8");
        SqlConnection con = new SqlConnection(conexao);

        //declaração do comando sql sendo inciado com null;
        SqlCommand cmd = null;

        //Criar o método para o comando SQL, que ficar responsável por inserir, atualizar e excluir e utilizar o parâmetro para inserir o comando SQL.
        public void ComandoSql(string Sql)
        {
            //abre a conexão
            con.Open();

            //Inseri o comando SQL e atribuir a conexão do banco de dados
            cmd = new SqlCommand(Sql, con);

            //executa o comando
            cmd.ExecuteNonQuery();

            //fecha a conexão
            con.Close();
        }

        public int ProximoCod()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select (max(Codigo) + 1) as Codigo from Contato",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() != "")
            {
                return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            else
            {
                return 1;    
            }
            

        }

        //Consulta no banco de dados utilizando o parâmetro DataGridView para a exibição dos dados, e outro parametro para o comando SQL.
        public void Consultar(DataGridView Dgv, string Sql)
        {
            con.Open();
            cmd = new SqlCommand(Sql, con);
            //Diz que o comando é uma query(Texto) e não uma StoredProcedure
            cmd.CommandType = CommandType.Text;

            //O SqlDataAdapter serve para ligar os dados que estão num banco de
            //dados SQL Server com os objetos DataSet e DataTable.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Dgv.DataSource = dt;
            con.Close();
        }
    }
}
