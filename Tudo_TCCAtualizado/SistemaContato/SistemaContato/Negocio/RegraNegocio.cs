using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContato
{
    public class RegraNegocio
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        Banco dados = new Banco();

        public void InserirContato()
        {
            try
            {
                dados.ComandoSql("insert into Contato (Codigo, Nome, Endereco, Telefone) values ('" + dados.ProximoCod() + "', '" + Nome + "', '" + Endereco + "', '" + Telefone + "')");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AtualizarContato()
        {
            try
            {
                dados.ComandoSql("update Contato set Nome = '" + Nome + "', Endereco = '" + Endereco + "' , Telefone = '" + Telefone + "' where Codigo = '" + Codigo + "'");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeletarContato(int Codigo)
        {
            try
            {
                dados.ComandoSql("delete from Contato where Codigo = '" + Codigo + "'");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void PreencherGrid(DataGridView Dgv)
        {
            try
            {
                dados.Consultar(Dgv, "select * from Contato");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ConsultarCodigo(DataGridView Dgv)
        {
            try
            {
                dados.Consultar(Dgv, "select * from Contato where Codigo = '" + Codigo + "'");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ConsultarNome(DataGridView Dgv)
        {
            try
            {
                dados.Consultar(Dgv, "select * from Contato where Nome like '%" + Nome + "%'");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ConsultarTelefone(DataGridView Dgv)
        {
            try
            {
                dados.Consultar(Dgv, "select * from Contato where Telefone like '%" + Telefone + "%'");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
