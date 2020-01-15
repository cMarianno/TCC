using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroGridview
{
    
    public class Funcionarios
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }

        public AcessoBanco AcessoBanco
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        AcessoBanco banco = new AcessoBanco();

        public void Inserir()
        {
            try
            {
                banco.ComandoSql("insert into Funcionario2 (Codigo, Nome, Endereco, CEP, Bairro, Cidade, UF, Telefone) values (" + banco.BuscarCodigo() + ", '" + Nome + "', '" + Endereco + "', '" + CEP + "', '" + Bairro + "', '" + Cidade + "', '" + UF + "', '" + Telefone + "')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualizar()
        {
            try
            {
                banco.ComandoSql("update Funcionario2 set Nome = '" + Nome + "', Endereco = '" + Endereco + "', CEP = '" + CEP + "', Bairro = '" + Bairro + "', Cidade = '" + Cidade + "', UF = '" + UF + "', Telefone = '" + Telefone + "' where Codigo = " + Codigo + "");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                banco.ComandoSql("delete from Funcionario2 where Codigo = " + Codigo + "");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Funcionarios> ConsultaGeral()
        {
            try
            {
                return banco.ListaFuncionarios("select * from Funcionario2");
                                
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<Funcionarios> ConsultaNome()
        {
            try
            {
                return banco.ListaFuncionarios("select * from Funcionario2 where Nome like '%" + Nome + "%'");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
