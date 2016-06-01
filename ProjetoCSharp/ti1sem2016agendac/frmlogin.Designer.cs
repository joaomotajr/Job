namespace ti1sem2016agendac
{
    partial class frmlogin
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lklblesquecisenha = new System.Windows.Forms.LinkLabel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenhaConfirma = new System.Windows.Forms.TextBox();
            this.lblpalavrachave = new System.Windows.Forms.Label();
            this.lblnovasenha = new System.Windows.Forms.Label();
            this.lblconfimasenha = new System.Windows.Forms.Label();
            this.btnlogar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblagdid = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.lklblcadastro = new System.Windows.Forms.LinkLabel();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbllogin.Location = new System.Drawing.Point(44, 48);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(33, 13);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsenha.Location = new System.Drawing.Point(47, 78);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(38, 13);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha";
            // 
            // lklblesquecisenha
            // 
            this.lklblesquecisenha.AutoSize = true;
            this.lklblesquecisenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lklblesquecisenha.Location = new System.Drawing.Point(275, 207);
            this.lklblesquecisenha.Name = "lklblesquecisenha";
            this.lklblesquecisenha.Size = new System.Drawing.Size(110, 13);
            this.lklblesquecisenha.TabIndex = 2;
            this.lklblesquecisenha.TabStop = true;
            this.lklblesquecisenha.Text = "Esqueci minha Senha";
            this.lklblesquecisenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblesquecisenha_LinkClicked);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(98, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(98, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '#';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(166, 262);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(100, 20);
            this.txtPalavraChave.TabIndex = 5;
            this.txtPalavraChave.Visible = false;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(166, 299);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '#';
            this.txtNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtNovaSenha.TabIndex = 6;
            this.txtNovaSenha.Visible = false;
            // 
            // txtNovaSenhaConfirma
            // 
            this.txtNovaSenhaConfirma.Location = new System.Drawing.Point(166, 337);
            this.txtNovaSenhaConfirma.Name = "txtNovaSenhaConfirma";
            this.txtNovaSenhaConfirma.PasswordChar = '#';
            this.txtNovaSenhaConfirma.Size = new System.Drawing.Size(100, 20);
            this.txtNovaSenhaConfirma.TabIndex = 7;
            this.txtNovaSenhaConfirma.Visible = false;
            // 
            // lblpalavrachave
            // 
            this.lblpalavrachave.AutoSize = true;
            this.lblpalavrachave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblpalavrachave.Location = new System.Drawing.Point(44, 269);
            this.lblpalavrachave.Name = "lblpalavrachave";
            this.lblpalavrachave.Size = new System.Drawing.Size(77, 13);
            this.lblpalavrachave.TabIndex = 8;
            this.lblpalavrachave.Text = "Palavra Chave";
            this.lblpalavrachave.Visible = false;
            // 
            // lblnovasenha
            // 
            this.lblnovasenha.AutoSize = true;
            this.lblnovasenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnovasenha.Location = new System.Drawing.Point(49, 306);
            this.lblnovasenha.Name = "lblnovasenha";
            this.lblnovasenha.Size = new System.Drawing.Size(38, 13);
            this.lblnovasenha.TabIndex = 9;
            this.lblnovasenha.Text = "Senha";
            this.lblnovasenha.Visible = false;
            // 
            // lblconfimasenha
            // 
            this.lblconfimasenha.AutoSize = true;
            this.lblconfimasenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblconfimasenha.Location = new System.Drawing.Point(44, 344);
            this.lblconfimasenha.Name = "lblconfimasenha";
            this.lblconfimasenha.Size = new System.Drawing.Size(85, 13);
            this.lblconfimasenha.TabIndex = 10;
            this.lblconfimasenha.Text = "Confirmar Senha";
            this.lblconfimasenha.Visible = false;
            // 
            // btnlogar
            // 
            this.btnlogar.Location = new System.Drawing.Point(98, 161);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(75, 23);
            this.btnlogar.TabIndex = 11;
            this.btnlogar.Text = "Logar";
            this.btnlogar.UseVisualStyleBackColor = true;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(338, 161);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 12;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Visible = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(98, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.Visible = false;
            // 
            // lblagdid
            // 
            this.lblagdid.AutoSize = true;
            this.lblagdid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblagdid.Location = new System.Drawing.Point(47, 18);
            this.lblagdid.Name = "lblagdid";
            this.lblagdid.Size = new System.Drawing.Size(40, 13);
            this.lblagdid.TabIndex = 14;
            this.lblagdid.Text = "Código";
            this.lblagdid.Visible = false;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(217, 161);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 15;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Visible = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // lklblcadastro
            // 
            this.lklblcadastro.AutoSize = true;
            this.lklblcadastro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lklblcadastro.Location = new System.Drawing.Point(120, 207);
            this.lklblcadastro.Name = "lklblcadastro";
            this.lklblcadastro.Size = new System.Drawing.Size(73, 13);
            this.lklblcadastro.TabIndex = 16;
            this.lklblcadastro.TabStop = true;
            this.lklblcadastro.Text = "Sem Cadastro";
            this.lklblcadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblcadastro_LinkClicked);
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Items.AddRange(new object[] {
            "Administrador ",
            "Usuário"});
            this.cbPerfil.Location = new System.Drawing.Point(188, 114);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbPerfil.TabIndex = 17;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 394);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.lklblcadastro);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.lblagdid);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnlogar);
            this.Controls.Add(this.lblconfimasenha);
            this.Controls.Add(this.lblnovasenha);
            this.Controls.Add(this.lblpalavrachave);
            this.Controls.Add(this.txtNovaSenhaConfirma);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtPalavraChave);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lklblesquecisenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lbllogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmlogin";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.LinkLabel lklblesquecisenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenhaConfirma;
        private System.Windows.Forms.Label lblpalavrachave;
        private System.Windows.Forms.Label lblnovasenha;
        private System.Windows.Forms.Label lblconfimasenha;
        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblagdid;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.LinkLabel lklblcadastro;
        private System.Windows.Forms.ComboBox cbPerfil;
    }
}