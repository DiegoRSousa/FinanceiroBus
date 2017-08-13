namespace FinanceiroBus.View
{
    partial class FormContrato
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoFinanceira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstituicaoEnsino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAtivado = new System.Windows.Forms.Label();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.cbxPlanoPagamento = new System.Windows.Forms.ComboBox();
            this.cbxInstituicaoEnsino = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxAluno = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvContratos);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtNomePesquisa);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 272);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listagem";
            // 
            // dgvContratos
            // 
            this.dgvContratos.AllowUserToAddRows = false;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataInicial,
            this.DataFinal,
            this.PlanoPagamento,
            this.SituacaoFinanceira,
            this.Aluno,
            this.InstituicaoEnsino,
            this.Ativo});
            this.dgvContratos.Location = new System.Drawing.Point(9, 48);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.Size = new System.Drawing.Size(663, 218);
            this.dgvContratos.TabIndex = 12;
            this.dgvContratos.SelectionChanged += new System.EventHandler(this.dgvContratos_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 40;
            // 
            // DataInicial
            // 
            this.DataInicial.HeaderText = "Data Inicial";
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Width = 75;
            // 
            // DataFinal
            // 
            this.DataFinal.HeaderText = "Data Final";
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Width = 75;
            // 
            // PlanoPagamento
            // 
            this.PlanoPagamento.HeaderText = "Plano Pagamento";
            this.PlanoPagamento.Name = "PlanoPagamento";
            this.PlanoPagamento.Width = 70;
            // 
            // SituacaoFinanceira
            // 
            this.SituacaoFinanceira.HeaderText = "Situação Financeira";
            this.SituacaoFinanceira.Name = "SituacaoFinanceira";
            this.SituacaoFinanceira.Width = 70;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.Width = 160;
            // 
            // InstituicaoEnsino
            // 
            this.InstituicaoEnsino.HeaderText = "Instituição de Ensino";
            this.InstituicaoEnsino.Name = "InstituicaoEnsino";
            this.InstituicaoEnsino.Width = 70;
            // 
            // Ativo
            // 
            this.Ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(301, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar - F12";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(50, 22);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(245, 20);
            this.txtNomePesquisa.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAtivado);
            this.groupBox1.Controls.Add(this.btnDesativar);
            this.groupBox1.Controls.Add(this.cbxPlanoPagamento);
            this.groupBox1.Controls.Add(this.cbxInstituicaoEnsino);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.cbxAluno);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 121);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // lblAtivado
            // 
            this.lblAtivado.AutoSize = true;
            this.lblAtivado.Location = new System.Drawing.Point(442, 90);
            this.lblAtivado.Name = "lblAtivado";
            this.lblAtivado.Size = new System.Drawing.Size(46, 13);
            this.lblAtivado.TabIndex = 16;
            this.lblAtivado.Text = "Ativado:";
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(597, 48);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(75, 23);
            this.btnDesativar.TabIndex = 8;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // cbxPlanoPagamento
            // 
            this.cbxPlanoPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPlanoPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPlanoPagamento.FormattingEnabled = true;
            this.cbxPlanoPagamento.Location = new System.Drawing.Point(314, 87);
            this.cbxPlanoPagamento.Name = "cbxPlanoPagamento";
            this.cbxPlanoPagamento.Size = new System.Drawing.Size(75, 21);
            this.cbxPlanoPagamento.TabIndex = 6;
            // 
            // cbxInstituicaoEnsino
            // 
            this.cbxInstituicaoEnsino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxInstituicaoEnsino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxInstituicaoEnsino.FormattingEnabled = true;
            this.cbxInstituicaoEnsino.Location = new System.Drawing.Point(105, 87);
            this.cbxInstituicaoEnsino.Name = "cbxInstituicaoEnsino";
            this.cbxInstituicaoEnsino.Size = new System.Drawing.Size(66, 21);
            this.cbxInstituicaoEnsino.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(597, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar - F8";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxAluno
            // 
            this.cbxAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAluno.FormattingEnabled = true;
            this.cbxAluno.Location = new System.Drawing.Point(49, 56);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(363, 21);
            this.cbxAluno.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(597, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar - F5";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(442, 59);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 12;
            this.lblSituacao.Text = "Situação:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(314, 19);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(98, 20);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(146, 19);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(98, 20);
            this.dtpDataInicial.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Plano de pagamento:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(31, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Instituição Ensino:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FormContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Contratos";
            this.Load += new System.EventHandler(this.FormContrato_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormContrato_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoFinanceira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstituicaoEnsino;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAtivado;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.ComboBox cbxPlanoPagamento;
        private System.Windows.Forms.ComboBox cbxInstituicaoEnsino;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxAluno;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}