namespace ti1sem2016agendac
{
    partial class tela_venda
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
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnlistardados = new System.Windows.Forms.Button();
            this.txtagdcpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtagdtelefone = new System.Windows.Forms.TextBox();
            this.txtagdemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtagdnome = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtagdid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(556, 357);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 33;
            this.btnsair.Text = "&SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(309, 357);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 32;
            this.btnlimpar.Text = "&LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnlistardados
            // 
            this.btnlistardados.Location = new System.Drawing.Point(40, 357);
            this.btnlistardados.Name = "btnlistardados";
            this.btnlistardados.Size = new System.Drawing.Size(180, 23);
            this.btnlistardados.TabIndex = 31;
            this.btnlistardados.Text = "CONSULTAR LISTA &DE DADOS";
            this.btnlistardados.UseVisualStyleBackColor = true;
            this.btnlistardados.Click += new System.EventHandler(this.btnlistardados_Click);
            // 
            // txtagdcpf
            // 
            this.txtagdcpf.Location = new System.Drawing.Point(556, 64);
            this.txtagdcpf.Name = "txtagdcpf";
            this.txtagdcpf.Size = new System.Drawing.Size(126, 20);
            this.txtagdcpf.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(515, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "CPF";
            // 
            // txtagdtelefone
            // 
            this.txtagdtelefone.Location = new System.Drawing.Point(442, 14);
            this.txtagdtelefone.Name = "txtagdtelefone";
            this.txtagdtelefone.Size = new System.Drawing.Size(124, 20);
            this.txtagdtelefone.TabIndex = 28;
            // 
            // txtagdemail
            // 
            this.txtagdemail.Location = new System.Drawing.Point(294, 63);
            this.txtagdemail.Name = "txtagdemail";
            this.txtagdemail.Size = new System.Drawing.Size(199, 20);
            this.txtagdemail.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(387, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Telefone";
            // 
            // txtagdnome
            // 
            this.txtagdnome.Location = new System.Drawing.Point(78, 8);
            this.txtagdnome.Name = "txtagdnome";
            this.txtagdnome.Size = new System.Drawing.Size(119, 20);
            this.txtagdnome.TabIndex = 25;
            this.txtagdnome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtagdnome_KeyUp);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(556, 270);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(85, 23);
            this.btnexcluir.TabIndex = 24;
            this.btnexcluir.Text = "&EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(385, 270);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(94, 23);
            this.btnconsultar.TabIndex = 23;
            this.btnconsultar.Text = "&CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(202, 270);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(103, 23);
            this.btnalterar.TabIndex = 22;
            this.btnalterar.Text = "&ALTERAR";
            this.btnalterar.UseVisualStyleBackColor = true;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(53, 270);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(94, 23);
            this.btnincluir.TabIndex = 21;
            this.btnincluir.Text = "&INCLUIR";
            this.btnincluir.UseVisualStyleBackColor = true;
            // 
            // txtagdid
            // 
            this.txtagdid.Location = new System.Drawing.Point(309, 11);
            this.txtagdid.Name = "txtagdid";
            this.txtagdid.Size = new System.Drawing.Size(40, 20);
            this.txtagdid.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(253, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Nome.Location = new System.Drawing.Point(251, 14);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 13);
            this.Nome.TabIndex = 17;
            this.Nome.Text = "Codigo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 95);
            this.listBox1.TabIndex = 34;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(40, 149);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(168, 95);
            this.listBox2.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // tela_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 434);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
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
            this.Name = "tela_venda";
            this.Text = "tela_venda";
            this.Load += new System.EventHandler(this.tela_venda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnlistardados;
        private System.Windows.Forms.TextBox txtagdcpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtagdtelefone;
        private System.Windows.Forms.TextBox txtagdemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtagdnome;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtagdid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}