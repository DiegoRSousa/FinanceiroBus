namespace FinanceiroBus.View
{
    partial class FormContaAReceber
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
            this.gbxListagem = new System.Windows.Forms.GroupBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbxCadastro = new System.Windows.Forms.GroupBox();
            this.lblCancelada = new System.Windows.Forms.Label();
            this.lblValorStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxAluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpCompetencia = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.gbxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxListagem
            // 
            this.gbxListagem.Controls.Add(this.dgvContas);
            this.gbxListagem.Controls.Add(this.btnPesquisar);
            this.gbxListagem.Controls.Add(this.txtNomePesquisa);
            this.gbxListagem.Controls.Add(this.label11);
            this.gbxListagem.Location = new System.Drawing.Point(13, 192);
            this.gbxListagem.Name = "gbxListagem";
            this.gbxListagem.Size = new System.Drawing.Size(891, 216);
            this.gbxListagem.TabIndex = 9;
            this.gbxListagem.TabStop = false;
            this.gbxListagem.Text = "Listagem";
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Aluno,
            this.Referencia,
            this.Competencia,
            this.Vencimento,
            this.Valor,
            this.Status,
            this.Cancelada});
            this.dgvContas.Location = new System.Drawing.Point(9, 48);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.Size = new System.Drawing.Size(872, 155);
            this.dgvContas.TabIndex = 12;
            this.dgvContas.SelectionChanged += new System.EventHandler(this.dgvContas_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 40;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.Width = 160;
            // 
            // Referencia
            // 
            this.Referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Referencia.HeaderText = "Refêrencia";
            this.Referencia.Name = "Referencia";
            // 
            // Competencia
            // 
            this.Competencia.HeaderText = "Competência";
            this.Competencia.Name = "Competencia";
            this.Competencia.Width = 75;
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.Width = 75;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 50;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 75;
            // 
            // Cancelada
            // 
            this.Cancelada.HeaderText = "Cancelada";
            this.Cancelada.Name = "Cancelada";
            this.Cancelada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cancelada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cancelada.Width = 60;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(301, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 23);
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
            // gbxCadastro
            // 
            this.gbxCadastro.Controls.Add(this.lblCancelada);
            this.gbxCadastro.Controls.Add(this.lblValorStatus);
            this.gbxCadastro.Controls.Add(this.lblStatus);
            this.gbxCadastro.Controls.Add(this.cbxAluno);
            this.gbxCadastro.Controls.Add(this.lblAluno);
            this.gbxCadastro.Controls.Add(this.btnLimpar);
            this.gbxCadastro.Controls.Add(this.dtpVencimento);
            this.gbxCadastro.Controls.Add(this.btnCancelar);
            this.gbxCadastro.Controls.Add(this.dtpCompetencia);
            this.gbxCadastro.Controls.Add(this.btnSalvar);
            this.gbxCadastro.Controls.Add(this.txtValor);
            this.gbxCadastro.Controls.Add(this.txtReferencia);
            this.gbxCadastro.Controls.Add(this.txtId);
            this.gbxCadastro.Controls.Add(this.lblCompetencia);
            this.gbxCadastro.Controls.Add(this.lblId);
            this.gbxCadastro.Controls.Add(this.lblReferencia);
            this.gbxCadastro.Controls.Add(this.lblVencimento);
            this.gbxCadastro.Controls.Add(this.lblValor);
            this.gbxCadastro.Location = new System.Drawing.Point(12, 12);
            this.gbxCadastro.Name = "gbxCadastro";
            this.gbxCadastro.Size = new System.Drawing.Size(489, 174);
            this.gbxCadastro.TabIndex = 8;
            this.gbxCadastro.TabStop = false;
            this.gbxCadastro.Text = "Cadastro";
            // 
            // lblCancelada
            // 
            this.lblCancelada.AutoSize = true;
            this.lblCancelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelada.ForeColor = System.Drawing.Color.Red;
            this.lblCancelada.Location = new System.Drawing.Point(397, 138);
            this.lblCancelada.Name = "lblCancelada";
            this.lblCancelada.Size = new System.Drawing.Size(80, 13);
            this.lblCancelada.TabIndex = 18;
            this.lblCancelada.Text = "CANCELADA";
            // 
            // lblValorStatus
            // 
            this.lblValorStatus.AutoSize = true;
            this.lblValorStatus.Location = new System.Drawing.Point(284, 138);
            this.lblValorStatus.Name = "lblValorStatus";
            this.lblValorStatus.Size = new System.Drawing.Size(13, 13);
            this.lblValorStatus.TabIndex = 17;
            this.lblValorStatus.Text = "0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(238, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // cbxAluno
            // 
            this.cbxAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAluno.FormattingEnabled = true;
            this.cbxAluno.Location = new System.Drawing.Point(124, 18);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(244, 21);
            this.cbxAluno.TabIndex = 2;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(81, 22);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 12;
            this.lblAluno.Text = "Aluno:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(400, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar - F8";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(270, 92);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(98, 20);
            this.dtpVencimento.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpCompetencia
            // 
            this.dtpCompetencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompetencia.Location = new System.Drawing.Point(84, 92);
            this.dtpCompetencia.Name = "dtpCompetencia";
            this.dtpCompetencia.Size = new System.Drawing.Size(98, 20);
            this.dtpCompetencia.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(400, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar - F5";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(50, 135);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(93, 20);
            this.txtValor.TabIndex = 6;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(78, 55);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(290, 20);
            this.txtReferencia.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(31, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(6, 95);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(72, 13);
            this.lblCompetencia.TabIndex = 1;
            this.lblCompetencia.Text = "Competência:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(10, 58);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(62, 13);
            this.lblReferencia.TabIndex = 2;
            this.lblReferencia.Text = "Referência:";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(198, 95);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(66, 13);
            this.lblVencimento.TabIndex = 3;
            this.lblVencimento.Text = "Vencimento:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(10, 138);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormContaAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 414);
            this.Controls.Add(this.gbxListagem);
            this.Controls.Add(this.gbxCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormContaAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Contas a Receber";
            this.Load += new System.EventHandler(this.FormContaAReceber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormContaAReceber_KeyDown);
            this.gbxListagem.ResumeLayout(false);
            this.gbxListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.gbxCadastro.ResumeLayout(false);
            this.gbxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxListagem;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cancelada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbxCadastro;
        private System.Windows.Forms.Label lblCancelada;
        private System.Windows.Forms.Label lblValorStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpCompetencia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}