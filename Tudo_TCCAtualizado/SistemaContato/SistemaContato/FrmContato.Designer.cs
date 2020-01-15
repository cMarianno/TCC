namespace SistemaContato
{
    partial class FrmContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxContato = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxFone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxFuncoes = new System.Windows.Forms.GroupBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.maskedTextBoxPesq = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPesq = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxContato.SuspendLayout();
            this.groupBoxFuncoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(145, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controle de Contatos";
            // 
            // groupBoxContato
            // 
            this.groupBoxContato.Controls.Add(this.maskedTextBoxFone);
            this.groupBoxContato.Controls.Add(this.textBoxEndereco);
            this.groupBoxContato.Controls.Add(this.textBoxNome);
            this.groupBoxContato.Controls.Add(this.textBoxCodigo);
            this.groupBoxContato.Controls.Add(this.label5);
            this.groupBoxContato.Controls.Add(this.label4);
            this.groupBoxContato.Controls.Add(this.label3);
            this.groupBoxContato.Controls.Add(this.label2);
            this.groupBoxContato.Location = new System.Drawing.Point(0, 88);
            this.groupBoxContato.Name = "groupBoxContato";
            this.groupBoxContato.Size = new System.Drawing.Size(490, 184);
            this.groupBoxContato.TabIndex = 2;
            this.groupBoxContato.TabStop = false;
            this.groupBoxContato.Text = "Dados";
            // 
            // maskedTextBoxFone
            // 
            this.maskedTextBoxFone.Location = new System.Drawing.Point(128, 148);
            this.maskedTextBoxFone.Mask = "(99) 00000-0000";
            this.maskedTextBoxFone.Name = "maskedTextBoxFone";
            this.maskedTextBoxFone.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxFone.TabIndex = 7;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(128, 105);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(314, 20);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(128, 65);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(314, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(128, 26);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(58, 20);
            this.textBoxCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // groupBoxFuncoes
            // 
            this.groupBoxFuncoes.Controls.Add(this.buttonExcluir);
            this.groupBoxFuncoes.Controls.Add(this.buttonAtualizar);
            this.groupBoxFuncoes.Controls.Add(this.buttonSalvar);
            this.groupBoxFuncoes.Controls.Add(this.buttonNovo);
            this.groupBoxFuncoes.Location = new System.Drawing.Point(0, 278);
            this.groupBoxFuncoes.Name = "groupBoxFuncoes";
            this.groupBoxFuncoes.Size = new System.Drawing.Size(490, 77);
            this.groupBoxFuncoes.TabIndex = 3;
            this.groupBoxFuncoes.TabStop = false;
            this.groupBoxFuncoes.Text = "Funções";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackgroundImage = global::SistemaContato.Properties.Resources.Excluir;
            this.buttonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Location = new System.Drawing.Point(398, 17);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(52, 51);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = global::SistemaContato.Properties.Resources.Atualizar;
            this.buttonAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Location = new System.Drawing.Point(278, 17);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(52, 51);
            this.buttonAtualizar.TabIndex = 2;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackgroundImage = global::SistemaContato.Properties.Resources.Salvar;
            this.buttonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalvar.Location = new System.Drawing.Point(159, 17);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(52, 51);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackgroundImage = global::SistemaContato.Properties.Resources.Novo;
            this.buttonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNovo.Location = new System.Drawing.Point(38, 17);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(52, 51);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaContato.Properties.Resources.Contato;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.buttonPesquisar);
            this.groupBoxFiltro.Controls.Add(this.maskedTextBoxPesq);
            this.groupBoxFiltro.Controls.Add(this.comboBoxPesq);
            this.groupBoxFiltro.Controls.Add(this.label6);
            this.groupBoxFiltro.Location = new System.Drawing.Point(0, 361);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(490, 58);
            this.groupBoxFiltro.TabIndex = 4;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(415, 19);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 8;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // maskedTextBoxPesq
            // 
            this.maskedTextBoxPesq.Location = new System.Drawing.Point(217, 22);
            this.maskedTextBoxPesq.Name = "maskedTextBoxPesq";
            this.maskedTextBoxPesq.Size = new System.Drawing.Size(192, 20);
            this.maskedTextBoxPesq.TabIndex = 7;
            // 
            // comboBoxPesq
            // 
            this.comboBoxPesq.FormattingEnabled = true;
            this.comboBoxPesq.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Telefone"});
            this.comboBoxPesq.Location = new System.Drawing.Point(90, 22);
            this.comboBoxPesq.Name = "comboBoxPesq";
            this.comboBoxPesq.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPesq.TabIndex = 6;
            this.comboBoxPesq.SelectedIndexChanged += new System.EventHandler(this.comboBoxPesq_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filtrar Por: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewLista);
            this.groupBox1.Location = new System.Drawing.Point(0, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 267);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.ReadOnly = true;
            this.dataGridViewLista.Size = new System.Drawing.Size(490, 251);
            this.dataGridViewLista.TabIndex = 0;
            this.dataGridViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellContentClick);
            this.dataGridViewLista.SelectionChanged += new System.EventHandler(this.dataGridViewLista_SelectionChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // FrmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.groupBoxFuncoes);
            this.Controls.Add(this.groupBoxContato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato";
            this.Load += new System.EventHandler(this.FrmContato_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxContato.ResumeLayout(false);
            this.groupBoxContato.PerformLayout();
            this.groupBoxFuncoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxContato;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxFuncoes;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPesq;
        private System.Windows.Forms.ComboBox comboBoxPesq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

