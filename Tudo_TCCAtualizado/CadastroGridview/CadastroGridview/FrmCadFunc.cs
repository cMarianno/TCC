using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroGridview
{
    public partial class FormMenu : Form
    {
        bool novo = false;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            //Prepara a tela para inserir um funcionario novo
            //limpa a tela e atualiza controles
            novo = true;
            LimparTela();
                        
            toolStripButtonSalvar.Enabled = true;            
            toolStripButtonExcluir.Enabled = true;
            textBoxNome.Enabled = true;
            textBoxEndereco.Enabled = true;
            maskedTextBoxCEP.Enabled = true;
            textBoxBairro.Enabled = true;
            textBoxCidade.Enabled = true;
            textBoxUF.Enabled = true;
            maskedTextBoxTelefone.Enabled = true;

        }

        public void LimparTela()
        {
            textBoxCodigo.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxEndereco.Text = string.Empty;
            maskedTextBoxCEP.Text = "";
            textBoxBairro.Text = string.Empty;
            textBoxCidade.Text = string.Empty;
            textBoxUF.Text = string.Empty;
            maskedTextBoxTelefone.Text = "";
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            //cria o objeto para ser salvo(inserido ou atualizado) no banco de dados
            //através da variavel novo verifica se atualiza ou insere

            Funcionarios func = new Funcionarios();            
            func.Nome = textBoxNome.Text;
            func.Endereco = textBoxEndereco.Text;
            func.CEP = maskedTextBoxCEP.Text;
            func.Bairro = textBoxBairro.Text;
            func.Cidade = textBoxCidade.Text;
            func.UF = textBoxUF.Text;
            func.Telefone = maskedTextBoxTelefone.Text;
            if (novo)
            {
                func.Inserir();
                MessageBox.Show("Funcionário Incluído com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                novo = false;
                LimparTela();
            }
            else
            {
                func.Codigo = int.Parse(textBoxCodigo.Text);
                func.Atualizar();
                MessageBox.Show("Funcionário Atualizado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            dataGridViewFuncionario.DataSource = func.ConsultaGeral();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //IniciarBotoes();
            novo = true;
            dataGridViewFuncionario.AutoGenerateColumns = false;
            Funcionarios func = new Funcionarios();
            dataGridViewFuncionario.DataSource = func.ConsultaGeral();
        }

        //metodo para inciar controle de botoes
        public void IniciarBotoes()
        {
            toolStripButtonNovo.Enabled = true;
            toolStripButtonSalvar.Enabled = false;           
            toolStripButtonExcluir.Enabled = false;
            toolStripButtonBuscar.Enabled = true;
            toolStripTextBoxNome.Enabled = true;
            textBoxNome.Enabled = false;
            textBoxEndereco.Enabled = false;
            maskedTextBoxCEP.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            textBoxUF.Enabled = false;
            maskedTextBoxTelefone.Enabled = false;
        }

        private void toolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionario.RowCount != 0)
            {
                Funcionarios func = new Funcionarios();

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    func.Codigo = int.Parse(textBoxCodigo.Text);
                    func.Excluir();
                    LimparTela();
                    MessageBox.Show("Funcionário Excluído com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewFuncionario.DataSource = func.ConsultaGeral();
                }
            }
                    
            
        }

        private void dataGridViewFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            //feito isso para não atualizar a tela no load do formulário
            //if (novo)
            // {
            //    return;
            //}

            novo = false;
            textBoxCodigo.Text = dataGridViewFuncionario.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewFuncionario.CurrentRow.Cells[1].Value.ToString();
            textBoxEndereco.Text = dataGridViewFuncionario.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxCEP.Text = dataGridViewFuncionario.CurrentRow.Cells[3].Value.ToString();
            textBoxBairro.Text = dataGridViewFuncionario.CurrentRow.Cells[4].Value.ToString();
            textBoxCidade.Text = dataGridViewFuncionario.CurrentRow.Cells[5].Value.ToString();
            textBoxUF.Text = dataGridViewFuncionario.CurrentRow.Cells[6].Value.ToString();
            maskedTextBoxTelefone.Text = dataGridViewFuncionario.CurrentRow.Cells[7].Value.ToString();

        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {            
            Funcionarios func = new Funcionarios();
            func.Nome = toolStripTextBoxNome.Text;
            dataGridViewFuncionario.DataSource = func.ConsultaNome();
            if (dataGridViewFuncionario.RowCount == 0)
            {
                MessageBox.Show("Não existem registros na base!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
