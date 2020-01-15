using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContato
{
    public partial class FrmContato : Form
    {
        RegraNegocio negocio = new RegraNegocio();

        public FrmContato()
        {
            InitializeComponent();
        }
        
        public void HabilitarControles()
        {
            textBoxNome.Enabled = true;
            textBoxEndereco.Enabled = true;
            maskedTextBoxFone.Enabled = true;
        }

        public void LimparCampos()
        {            
            foreach (Control cont in this.Controls)
            {
                if (cont is GroupBox)
                {
                    for (int i = 0; i < cont.Controls.Count; i++)
                    {
                        if (cont.Controls[i] is TextBox)
                        {
                            (cont.Controls[i] as TextBox).Text = "";
                        }
                        if (cont.Controls[i] is ComboBox)
                        {
                            (cont.Controls[i] as ComboBox).SelectedIndex = -1;
                        }
                        if (cont.Controls[i] is MaskedTextBox)
                        {
                            (cont.Controls[i] as MaskedTextBox).Text = "";
                        }
                    }
                }
            }
        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            buttonNovo.Enabled = true;
            negocio.PreencherGrid(dataGridViewLista);
            
            toolTip1.SetToolTip(this.buttonNovo, "Novo");
            toolTip1.SetToolTip(this.buttonSalvar, "Salvar");
            toolTip1.SetToolTip(this.buttonAtualizar, "Atualizar");
            toolTip1.SetToolTip(this.buttonExcluir, "Excluir");
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            buttonNovo.Enabled = false;
            buttonAtualizar.Enabled = false;
            buttonExcluir.Enabled = false;
            
            if (textBoxNome.Text != null)
            {
                textBoxNome.Focus();
                buttonSalvar.Enabled = true;
            }
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != null )
            {
                RegraNegocio contato = new RegraNegocio();
                contato.Nome = this.textBoxNome.Text;
                contato.Endereco = this.textBoxEndereco.Text;
                contato.Telefone = this.maskedTextBoxFone.Text;
                contato.InserirContato();

                negocio.PreencherGrid(dataGridViewLista);
                
                buttonSalvar.Enabled = false;
                buttonAtualizar.Enabled = true;
                buttonExcluir.Enabled = true;
                buttonNovo.Enabled = true;

                MessageBox.Show("Contato cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                textBoxNome.Focus();
                buttonNovo.Enabled = false;
                MessageBox.Show("Adicione um nome de contato", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text != null)
                {
                    negocio.Codigo = int.Parse(textBoxCodigo.Text);
                    negocio.Nome = textBoxNome.Text;
                    negocio.Endereco = textBoxEndereco.Text;
                    negocio.Telefone = maskedTextBoxFone.Text;
                    negocio.AtualizarContato();
                    negocio.PreencherGrid(dataGridViewLista);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
        private void dataGridViewLista_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarControles();
            buttonAtualizar.Enabled = true;
            buttonExcluir.Enabled = true;
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;

            textBoxCodigo.Text = dataGridViewLista.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewLista.CurrentRow.Cells[1].Value.ToString();
            textBoxEndereco.Text = dataGridViewLista.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxFone.Text = dataGridViewLista.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != null)
            {           
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }

                RegraNegocio contato = new RegraNegocio();
                contato.Codigo = int.Parse(this.textBoxCodigo.Text);
                contato.DeletarContato(contato.Codigo);
                negocio.PreencherGrid(dataGridViewLista);

                LimparCampos();
                HabilitarControles();
                textBoxNome.Focus();
                buttonSalvar.Enabled = false;
                buttonAtualizar.Enabled = false;
                buttonExcluir.Enabled = false;
                buttonNovo.Enabled = true;
                
                MessageBox.Show("Contato excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBoxNome.Focus();
                buttonSalvar.Enabled = false;
                buttonAtualizar.Enabled = false;
                buttonExcluir.Enabled = false;
                buttonNovo.Enabled = true;
                MessageBox.Show("Não existe contato para ser excluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //realiza a pesquisa por codigo e devolve o resultado no grid    
            if (comboBoxPesq.Text == "Código")
            {
                negocio.Codigo = int.Parse(maskedTextBoxPesq.Text);
                negocio.ConsultarCodigo(dataGridViewLista);
            }
            //realiza a pesquisa por nome e devolve o resultado no grid
            if (comboBoxPesq.Text == "Nome")
            {
                negocio.Nome = maskedTextBoxPesq.Text;
                negocio.ConsultarNome(dataGridViewLista);
            }
            //realiza a pesquisa por telefone e devolve o resultado no grid
            if (comboBoxPesq.Text == "Telefone")
            {
                negocio.Telefone = maskedTextBoxFone.Text;
                negocio.ConsultarTelefone(dataGridViewLista);
            }

            if (comboBoxPesq.Text == "")
            {
                negocio.PreencherGrid(dataGridViewLista);
            }
        }

        private void comboBoxPesq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPesq.Text == "Telefone")
            {
                maskedTextBoxPesq.Text = "(00)0000-0000";
            }
            else
            {
                maskedTextBoxPesq.Clear();
                maskedTextBoxPesq.Text = "";           
            }
        }

        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
