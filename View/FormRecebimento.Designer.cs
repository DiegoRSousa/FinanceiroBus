namespace FinanceiroBus.View
{
    partial class FormRecebimento
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
            this.dgvRecebimentos = new System.Windows.Forms.DataGridView();
            this.IdRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbxCadastro = new System.Windows.Forms.GroupBox();
            this.lblTotal0 = new System.Windows.Forms.Label();
            this.lblContas = new System.Windows.Forms.Label();
            this.dgvContasAReceber = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competência = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxAluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebimentos)).BeginInit();
            this.gbxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasAReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxListagem
            // 
            this.gbxListagem.Controls.Add(this.dgvRecebimentos);
            this.gbxListagem.Controls.Add(this.btnPesquisar);
            this.gbxListagem.Controls.Add(this.txtNomePesquisa);
            this.gbxListagem.Controls.Add(this.label11);
            this.gbxListagem.Location = new System.Drawing.Point(12, 207);
            this.gbxListagem.Name = "gbxListagem";
            this.gbxListagem.Size = new System.Drawing.Size(628, 196);
            this.gbxListagem.TabIndex = 10;
            this.gbxListagem.TabStop = false;
            this.gbxListagem.Text = "Listagem";
            // 
            // dgvRecebimentos
            // 
            this.dgvRecebimentos.AllowUserToAddRows = false;
            this.dgvRecebimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecebimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRecebimento,
            this.Aluno,
            this.Data,
            this.ValorRecebimento,
            this.Cancelado});
            this.dgvRecebimentos.Location = new System.Drawing.Point(9, 48);
            this.dgvRecebimentos.Name = "dgvRecebimentos";
            this.dgvRecebimentos.Size = new System.Drawing.Size(604, 142);
            this.dgvRecebimentos.TabIndex = 12;
            this.dgvRecebimentos.SelectionChanged += new System.EventHandler(this.dgvRecebimentos_SelectionChanged);
            // 
            // IdRecebimento
            // 
            this.IdRecebimento.HeaderText = "Id";
            this.IdRecebimento.Name = "IdRecebimento";
            this.IdRecebimento.Width = 40;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.Width = 320;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 75;
            // 
            // ValorRecebimento
            // 
            this.ValorRecebimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorRecebimento.HeaderText = "Valor";
            this.ValorRecebimento.Name = "ValorRecebimento";
            // 
            // Cancelado
            // 
            this.Cancelado.HeaderText = "Cancelado";
            this.Cancelado.Name = "Cancelado";
            this.Cancelado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cancelado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cancelado.Width = 70;
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
            this.gbxCadastro.Controls.Add(this.lblTotal0);
            this.gbxCadastro.Controls.Add(this.lblContas);
            this.gbxCadastro.Controls.Add(this.dgvContasAReceber);
            this.gbxCadastro.Controls.Add(this.cbxAluno);
            this.gbxCadastro.Controls.Add(this.lblAluno);
            this.gbxCadastro.Controls.Add(this.btnLimpar);
            this.gbxCadastro.Controls.Add(this.btnCancelar);
            this.gbxCadastro.Controls.Add(this.dtpData);
            this.gbxCadastro.Controls.Add(this.btnSalvar);
            this.gbxCadastro.Controls.Add(this.txtId);
            this.gbxCadastro.Controls.Add(this.lblData);
            this.gbxCadastro.Controls.Add(this.lblId);
            this.gbxCadastro.Controls.Add(this.lblTotal);
            this.gbxCadastro.Location = new System.Drawing.Point(12, 12);
            this.gbxCadastro.Name = "gbxCadastro";
            this.gbxCadastro.Size = new System.Drawing.Size(628, 189);
            this.gbxCadastro.TabIndex = 9;
            this.gbxCadastro.TabStop = false;
            this.gbxCadastro.Text = "Cadastro";
            // 
            // lblTotal0
            // 
            this.lblTotal0.AutoSize = true;
            this.lblTotal0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal0.Location = new System.Drawing.Point(453, 121);
            this.lblTotal0.Name = "lblTotal0";
            this.lblTotal0.Size = new System.Drawing.Size(29, 31);
            this.lblTotal0.TabIndex = 15;
            this.lblTotal0.Text = "0";
            // 
            // lblContas
            // 
            this.lblContas.AutoSize = true;
            this.lblContas.Location = new System.Drawing.Point(6, 54);
            this.lblContas.Name = "lblContas";
            this.lblContas.Size = new System.Drawing.Size(138, 13);
            this.lblContas.TabIndex = 14;
            this.lblContas.Text = "Contas a receber em aberto";
            // 
            // dgvContasAReceber
            // 
            this.dgvContasAReceber.AllowUserToAddRows = false;
            this.dgvContasAReceber.AllowUserToDeleteRows = false;
            this.dgvContasAReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasAReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Competência,
            this.Vencimento,
            this.Valor});
            this.dgvContasAReceber.Location = new System.Drawing.Point(6, 70);
            this.dgvContasAReceber.Name = "dgvContasAReceber";
            this.dgvContasAReceber.ReadOnly = true;
            this.dgvContasAReceber.Size = new System.Drawing.Size(316, 95);
            this.dgvContasAReceber.TabIndex = 13;
            this.dgvContasAReceber.SelectionChanged += new System.EventHandler(this.dgvContasAReceber_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Competência
            // 
            this.Competência.HeaderText = "Competencia";
            this.Competência.Name = "Competência";
            this.Competência.ReadOnly = true;
            this.Competência.Width = 75;
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 75;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // cbxAluno
            // 
            this.cbxAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAluno.FormattingEnabled = true;
            this.cbxAluno.Location = new System.Drawing.Point(131, 19);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(228, 21);
            this.cbxAluno.TabIndex = 2;
            this.cbxAluno.SelectedIndexChanged += new System.EventHandler(this.cbxAluno_SelectedIndexChanged);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(88, 22);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(37, 13);
            this.lblAluno.TabIndex = 12;
            this.lblAluno.Text = "Aluno:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(538, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar - F8";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(538, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(415, 20);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(98, 20);
            this.dtpData.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(538, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar - F5";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(31, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(376, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(364, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 31);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 407);
            this.Controls.Add(this.gbxListagem);
            this.Controls.Add(this.gbxCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormRecebimento";
            this.Text = "Manutenção de Recebimento de Contas";
            this.Load += new System.EventHandler(this.FormRecebimento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRecebimento_KeyDown);
            this.gbxListagem.ResumeLayout(false);
            this.gbxListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebimentos)).EndInit();
            this.gbxCadastro.ResumeLayout(false);
            this.gbxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasAReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxListagem;
        private System.Windows.Forms.DataGridView dgvRecebimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRecebimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cancelado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbxCadastro;
        private System.Windows.Forms.Label lblTotal0;
        private System.Windows.Forms.Label lblContas;
        private System.Windows.Forms.DataGridView dgvContasAReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competência;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.ComboBox cbxAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}