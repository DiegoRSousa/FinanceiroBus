namespace FinanceiroBus.View
{
    partial class FormConfiguracaoEmail
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
            this.gbxConfiguracao = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSMTP = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxConfiguracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxConfiguracao
            // 
            this.gbxConfiguracao.Controls.Add(this.txtId);
            this.gbxConfiguracao.Controls.Add(this.txtPorta);
            this.gbxConfiguracao.Controls.Add(this.lblPorta);
            this.gbxConfiguracao.Controls.Add(this.btnSalvar);
            this.gbxConfiguracao.Controls.Add(this.txtSMTP);
            this.gbxConfiguracao.Controls.Add(this.txtSenha);
            this.gbxConfiguracao.Controls.Add(this.txtEmail);
            this.gbxConfiguracao.Controls.Add(this.lblSMTP);
            this.gbxConfiguracao.Controls.Add(this.lblSenha);
            this.gbxConfiguracao.Controls.Add(this.lblEmail);
            this.gbxConfiguracao.Location = new System.Drawing.Point(12, 12);
            this.gbxConfiguracao.Name = "gbxConfiguracao";
            this.gbxConfiguracao.Size = new System.Drawing.Size(394, 148);
            this.gbxConfiguracao.TabIndex = 1;
            this.gbxConfiguracao.TabStop = false;
            this.gbxConfiguracao.Text = "Configuração";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(73, 110);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(209, 20);
            this.txtPorta.TabIndex = 4;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(32, 114);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 13);
            this.lblPorta.TabIndex = 7;
            this.lblPorta.Text = "Porta:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(313, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar - F5";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(73, 84);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(209, 20);
            this.txtSMTP.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(73, 58);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(209, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblSMTP
            // 
            this.lblSMTP.AutoSize = true;
            this.lblSMTP.Location = new System.Drawing.Point(27, 88);
            this.lblSMTP.Name = "lblSMTP";
            this.lblSMTP.Size = new System.Drawing.Size(40, 13);
            this.lblSMTP.TabIndex = 2;
            this.lblSMTP.Text = "SMTP:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(26, 62);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormConfiguracaoEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 166);
            this.Controls.Add(this.gbxConfiguracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormConfiguracaoEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracao";
            this.Load += new System.EventHandler(this.FormConfiguracaoEmail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConfiguracaoEmail_KeyDown);
            this.gbxConfiguracao.ResumeLayout(false);
            this.gbxConfiguracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConfiguracao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSMTP;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}