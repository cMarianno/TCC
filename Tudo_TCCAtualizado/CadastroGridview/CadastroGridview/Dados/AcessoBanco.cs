using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroGridview
{
    public class AcessoBanco
    {
        //SqlConnection con = new SqlConnection (@"Password=12345;Persist Security Info=True;User ID=sa;Initial Catalog=Mauricio;Data Source=LAPTOP-P5TJIN1S\SQLEXPRESS14");
        SqlConnection con = new SqlConnection("Password=200599;Persist Security Info=True;User ID = mauricio; Initial Catalog = Mauricio; Data Source = 10.101.148.8");
        SqlCommand cmd = null;

        public Funcionarios Funcionarios
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void ComandoSql(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int BuscarCodigo()
        {           
            SqlDataAdapter da = new SqlDataAdapter("select (max(Codigo) + 1) as Codigo from Funcionario2", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() != "")
            {
                return int.Parse(dt.Rows[0][0].ToString());
            }
            else
            {
                return 1;
            }
            
        }

        public List<Funcionarios> ListaFuncionarios(string sql)
        {
            List<Funcionarios> listfunc = new List<Funcionarios>();
            
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Funcionarios funcionarios = new Funcionarios();
                funcionarios.Codigo = int.Parse(item["Codigo"].ToString());
                funcionarios.Nome = item["Nome"].ToString();
                funcionarios.Endereco = item["Endereco"].ToString();
                funcionarios.CEP = item["CEP"].ToString();
                funcionarios.Bairro = item["Bairro"].ToString();
                funcionarios.Cidade = item["Cidade"].ToString();
                funcionarios.UF = item["UF"].ToString();
                funcionarios.Telefone = item["Telefone"].ToString();

                listfunc.Add(funcionarios);
            }

            return listfunc;
        }
    }
}
