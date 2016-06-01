using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Data;
namespace ti1sem2016agendac
{
    public partial class frmlogin : Form
    {
        public frmlogin()

        {
            InitializeComponent();
        }
        MySqlConnection conexao = new MySqlConnection();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leitor;
        int codigo;

        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.ConnectionString = "server=localhost;Database = ti1sem2016;UID=root;PWD=pass;Port=3306";

                conexao.Open();
            }

            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            try
            {

                string strsql = "select * from tb_login where login = '" + txtLogin.Text + "' and senha = '" + txtSenha.Text + "' and perfil = '" + cbPerfil.Text + "'";                
                comando.Connection = conexao;
                comando.CommandText = strsql;
                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    MessageBox.Show(" Logado com sucesso", " Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!leitor.IsClosed) {leitor.Close();}
                   tela_cadastroCliente form1 = new tela_cadastroCliente ();
                    form1.Show();
                }
                else
                    {
                        if (!leitor.IsClosed) { leitor.Close(); }
                        MessageBox.Show("Dados incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
            
            catch (Exception Erro)
            {
                MessageBox.Show("Erro na validação do login ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void telaSemcadastro()
        {
            lblagdid.Visible = true;
            txtCodigo.Visible = true;
            lblsenha.Visible = false;
            txtSenha.Visible = false;
            btncadastrar.Visible = true;
            btnlogar.Visible = false;
            lblpalavrachave.Visible = true;
            lblnovasenha.Visible = true;
            lblconfimasenha.Visible = true;
            txtPalavraChave.Visible = true;
            txtNovaSenha.Visible = true;
            txtNovaSenhaConfirma.Visible = true;
            lklblesquecisenha.Visible = true;

        }
        private void telaLogin()
        {
            lblagdid.Visible = false;
            txtCodigo.Visible = false;
            lblsenha.Visible = true;
            txtSenha.Visible = true;
            btncadastrar.Visible = false;
            btnlogar.Visible = true;
            lblpalavrachave.Visible = false;
            lblnovasenha.Visible = false;
            lblconfimasenha.Visible = false;
            txtPalavraChave.Visible = false;
            txtNovaSenha.Visible = false;
            txtNovaSenhaConfirma.Visible = false;
            lklblesquecisenha.Visible = true;


        }

        private void lklblcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaSemcadastro();

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // verifca se o cliente ja tem login cadastrado
                    string strsql = "select * from tb_login where login = '" + txtLogin.Text + "'";                    
                    comando.Connection = conexao;
                    comando.CommandText = strsql;
                    leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        MessageBox.Show("LOGIN Já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!leitor.IsClosed) { leitor.Close(); }
                        telaLogin();

                    }
                    else
                    //verifica se tem cadastro na agenda
                    {
                        if (!leitor.IsClosed) { leitor.Close(); }

                        ////strsql = "select * from agenda where agdid = " + txtCodigo.Text;
                        //////  'a' and senha = 'a' and perfil = 'adm'
                        ////comando.Connection = conexao;
                        ////comando.CommandText = strsql;
                        ////leitor = comando.ExecuteReader();

                        ////if (!leitor.HasRows)
                        ////// se o leitor nao trouxer nenhuma informação de cadastro
                        ////{
                        ////    MessageBox.Show(" Você nao esta cadastrado no nosso sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ////    if (!leitor.IsClosed) { leitor.Close(); }
                        ////    tela_cadastroCliente abreform1 = new tela_cadastroCliente();
                        ////    abreform1.Show();

                        ////}
                        ////else
                        ////{
                            if (!leitor.IsClosed) { leitor.Close(); }
                            
                            // insert to tblogin                            
                            strsql = " insert into tb_login(login, senha, perfil, palavra_chave)";
                            strsql += " values  ('" + txtLogin.Text + "','";
                            strsql += txtNovaSenha.Text + "' , '" + cbPerfil.Text + "' , '" + txtPalavraChave.Text + "')";

                            comando.Connection = conexao;
                            comando.CommandText = strsql;
                            comando.ExecuteNonQuery();

                            MessageBox.Show("Cadastro efetuado com sucesso !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            limpartelalogin();
                            telaLogin();

                        ////}
                    }
                }

                catch (Exception Erro)
                {
                    MessageBox.Show("Erro na validação do login ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

     
        private void limpartelalogin()
{
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtCodigo.Clear();
                    txtPalavraChave. Clear();
                    txtNovaSenhaConfirma.Clear();
                    txtNovaSenha.Clear();
                    cbPerfil.Text ="";
                    txtLogin.Focus();
}

        private void lklblesquecisenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaSemcadastro();
            btnalterar.Visible = true;
            btncadastrar.Visible = false;
            lklblcadastro.Visible = false;
        }


        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text != txtNovaSenhaConfirma.Text)
            {
                txtNovaSenha.Clear();
                txtNovaSenhaConfirma.Clear();
                txtNovaSenha.Focus();
                MessageBox.Show("Senha nao bate", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //verifica palavra chave
                    string strsql = "select * from tblogin where login = '" + txtLogin.Text + "' and palavrachave = '" + txtPalavraChave.Text + "' and agdid = " + txtCodigo.Text + " and perfil = '" + cbPerfil.Text + "'";
                    //  'a' and senha = 'a' and perfil = 'adm'
                    comando.Connection = conexao;
                    comando.CommandText = strsql;
                    leitor = comando.ExecuteReader();
                    if (!leitor.HasRows)//se ele nao trouxer resultado
                    {
                        MessageBox.Show(" Dados não conferem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (!leitor.IsClosed) { leitor.Close(); }

                    }
                    else //se ele trouxer resultado
                    {
                        if (!leitor.IsClosed) { leitor.Close(); }

                        strsql = " Update tblogin set ";
                        strsql += "senha = '" + txtNovaSenha.Text + "' ";
                        strsql += "where agdid = " + txtCodigo.Text;
                        comando.Connection = conexao;
                        comando.CommandText = strsql;
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Senha alterada com sucesso!!!", " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnlimpar_click(sender, e ):
                        telaLogin();
                    }

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro nos dados na validação da senha ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
