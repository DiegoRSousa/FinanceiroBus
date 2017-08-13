namespace FinanceiroBus.View
{
    partial class FormCalculadoraMensalidade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumeroDeAlunosParcial = new System.Windows.Forms.TextBox();
            this.txtNumeroDeAlunosIntegral = new System.Windows.Forms.TextBox();
            this.txtValorMotorista = new System.Windows.Forms.TextBox();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblTotalParcial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotaIntegral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtNumeroDeAlunosParcial);
            this.groupBox1.Controls.Add(this.txtNumeroDeAlunosIntegral);
            this.groupBox1.Controls.Add(this.txtValorMotorista);
            this.groupBox1.Controls.Add(this.txtValorCombustivel);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.lblTotalParcial);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTotaIntegral);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 239);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular Mensalidade";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 161);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumeroDeAlunosParcial
            // 
            this.txtNumeroDeAlunosParcial.Location = new System.Drawing.Point(197, 125);
            this.txtNumeroDeAlunosParcial.Name = "txtNumeroDeAlunosParcial";
            this.txtNumeroDeAlunosParcial.Size = new System.Drawing.Size(84, 20);
            this.txtNumeroDeAlunosParcial.TabIndex = 6;
            // 
            // txtNumeroDeAlunosIntegral
            // 
            this.txtNumeroDeAlunosIntegral.Location = new System.Drawing.Point(197, 102);
            this.txtNumeroDeAlunosIntegral.Name = "txtNumeroDeAlunosIntegral";
            this.txtNumeroDeAlunosIntegral.Size = new System.Drawing.Size(84, 20);
            this.txtNumeroDeAlunosIntegral.TabIndex = 5;
            // 
            // txtValorMotorista
            // 
            this.txtValorMotorista.Location = new System.Drawing.Point(197, 77);
            this.txtValorMotorista.Name = "txtValorMotorista";
            this.txtValorMotorista.Size = new System.Drawing.Size(84, 20);
            this.txtValorMotorista.TabIndex = 3;
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.Location = new System.Drawing.Point(197, 51);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(84, 20);
            this.txtValorCombustivel.TabIndex = 2;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(197, 28);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(84, 20);
            this.txtDias.TabIndex = 1;
            // 
            // lblTotalParcial
            // 
            this.lblTotalParcial.AutoSize = true;
            this.lblTotalParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParcial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalParcial.Location = new System.Drawing.Point(333, 199);
            this.lblTotalParcial.Name = "lblTotalParcial";
            this.lblTotalParcial.Size = new System.Drawing.Size(19, 20);
            this.lblTotalParcial.TabIndex = 8;
            this.lblTotalParcial.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(214, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Parcial:";
            // 
            // lblTotaIntegral
            // 
            this.lblTotaIntegral.AutoSize = true;
            this.lblTotaIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaIntegral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotaIntegral.Location = new System.Drawing.Point(143, 199);
            this.lblTotaIntegral.Name = "lblTotaIntegral";
            this.lblTotaIntegral.Size = new System.Drawing.Size(19, 20);
            this.lblTotaIntegral.TabIndex = 6;
            this.lblTotaIntegral.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(16, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Integral:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alunos Plano Parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Combustível:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alunos Plano Integral:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Motorista:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormCalculadoraMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 257);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalculadoraMensalidade";
            this.Text = "Calculadora de Mensalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumeroDeAlunosParcial;
        private System.Windows.Forms.TextBox txtNumeroDeAlunosIntegral;
        private System.Windows.Forms.TextBox txtValorMotorista;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblTotalParcial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotaIntegral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}