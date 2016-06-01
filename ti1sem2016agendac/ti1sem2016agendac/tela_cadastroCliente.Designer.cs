namespace ti1sem2016agendac
{
    partial class tela_cadastroCliente
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
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtagdid = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.txtagdnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtagdemail = new System.Windows.Forms.TextBox();
            this.txtagdtelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtagdcpf = new System.Windows.Forms.TextBox();
            this.btnlistardados = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Nome.Location = new System.Drawing.Point(24, 40);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Codigo";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(390, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtagdid
            // 
            this.txtagdid.Enabled = false;
            this.txtagdid.Location = new System.Drawing.Point(81, 40);
            this.txtagdid.Name = "txtagdid";
            this.txtagdid.Size = new System.Drawing.Size(100, 20);
            this.txtagdid.TabIndex = 3;
            this.txtagdid.TextChanged += new System.EventHandler(this.txtagdid_TextChanged);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(27, 298);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(94, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "&INCLUIR";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Enabled = false;
            this.btnalterar.Location = new System.Drawing.Point(176, 298);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(103, 23);
            this.btnalterar.TabIndex = 5;
            this.btnalterar.Text = "&ALTERAR";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(359, 298);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(94, 23);
            this.btnconsultar.TabIndex = 6;
            this.btnconsultar.Text = "&CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Enabled = false;
            this.btnexcluir.Location = new System.Drawing.Point(530, 298);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(85, 23);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "&EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // txtagdnome
            // 
            this.txtagdnome.Location = new System.Drawing.Point(445, 37);
            this.txtagdnome.Name = "txtagdnome";
            this.txtagdnome.Size = new System.Drawing.Size(182, 20);
            this.txtagdnome.TabIndex = 8;
            this.txtagdnome.TextChanged += new System.EventHandler(this.txtagdnome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(390, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefone";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtagdemail
            // 
            this.txtagdemail.Location = new System.Drawing.Point(68, 103);
            this.txtagdemail.Name = "txtagdemail";
            this.txtagdemail.Size = new System.Drawing.Size(199, 20);
            this.txtagdemail.TabIndex = 10;
            this.txtagdemail.TextChanged += new System.EventHandler(this.txtagdemail_TextChanged);
            // 
            // txtagdtelefone
            // 
            this.txtagdtelefone.Location = new System.Drawing.Point(445, 97);
            this.txtagdtelefone.Name = "txtagdtelefone";
            this.txtagdtelefone.Size = new System.Drawing.Size(124, 20);
            this.txtagdtelefone.TabIndex = 11;
            this.txtagdtelefone.TextChanged += new System.EventHandler(this.txtagdtelefone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(27, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtagdcpf
            // 
            this.txtagdcpf.Location = new System.Drawing.Point(68, 166);
            this.txtagdcpf.Name = "txtagdcpf";
            this.txtagdcpf.Size = new System.Drawing.Size(126, 20);
            this.txtagdcpf.TabIndex = 13;
            this.txtagdcpf.TextChanged += new System.EventHandler(this.txtagdcpf_TextChanged);
            // 
            // btnlistardados
            // 
            this.btnlistardados.Location = new System.Drawing.Point(14, 385);
            this.btnlistardados.Name = "btnlistardados";
            this.btnlistardados.Size = new System.Drawing.Size(180, 23);
            this.btnlistardados.TabIndex = 14;
            this.btnlistardados.Text = "CONSULTAR LISTA &DE DADOS";
            this.btnlistardados.UseVisualStyleBackColor = true;
            this.btnlistardados.Click += new System.EventHandler(this.btnlistardados_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(283, 385);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 15;
            this.btnlimpar.Text = "&LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(530, 385);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 16;
            this.btnsair.Text = "&SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // tela_cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 433);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnlistardados);
            this.Controls.Add(this.txtagdcpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtagdtelefone);
            this.Controls.Add(this.txtagdemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtagdnome);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtagdid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "tela_cadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtagdid;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.TextBox txtagdnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtagdemail;
        private System.Windows.Forms.TextBox txtagdtelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtagdcpf;
        private System.Windows.Forms.Button btnlistardados;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

