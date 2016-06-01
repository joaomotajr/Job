using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ti1sem2016agendac
{
    public partial class tela_cadastroCliente : Form
    {
        public tela_cadastroCliente()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao = new MySqlConnection();
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader leitor;


        private void Form1_Load(object sender, EventArgs e)
        {
            btnalterar.Enabled = false;
            btnexcluir.Enabled = false;

            try
            {
                conexao.ConnectionString = "server=localhost;Database = ti1sem2016;UID=root;PWD=pass;Port=3306";
                conexao.Open();
            }

            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        //string campo, tabela;
        private void btnincluir_Click(object sender, EventArgs e)
        {
           
            try
            {
                string strsql = " select * from tb_cliente where CPF_cliente = '" + txtagdcpf.Text + "'";
                comando.Connection = conexao;
                comando.CommandText = strsql;

                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    MessageBox.Show("esse codigo ja existe!!!", "ADO.NET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    //se leitor nao estiver fechado entao fecha leitor
                    if (!leitor.IsClosed) { leitor.Close(); }

                    strsql = "insert into tb_cliente (nome_cliente, email_cliente, tel_cliente, CPF_cliente) values ('";                    
                    strsql += txtagdnome.Text + "' ,";
                    strsql += "'" + txtagdemail.Text + " ',";
                    strsql += "'" + txtagdtelefone.Text + " ',";
                    strsql += "'" + txtagdcpf.Text + "')";

                    comando.Connection = conexao;
                    comando.CommandText = strsql;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("registro incluido com sucesso!!!", "ADO.NET",

                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                if (!leitor.IsClosed)
                {
                    leitor.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro na inclusao ==>" + Erro.Message, "ADO.NET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = "select * from tb_cliente where cod_cliente = " + txtagdid.Text;
                comando.Connection = conexao;
                comando.CommandText = strsql;
                leitor = comando.ExecuteReader();

                if (!leitor.HasRows)
                {
                    MessageBox.Show("codigo inexistente !!!", "ADO.NET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtagdid.Clear();
                    txtagdid.Focus();

                }
                else
                {
                    //picturebox1.image = properties.resources._1;
                    if (!leitor.IsClosed) { leitor.Close(); }

                    strsql = "update tb_cliente set ";
                    strsql += "nome_cliente = '" + txtagdnome.Text + "', ";
                    strsql += "email_cliente = '" + txtagdemail.Text + "',";
                    strsql += "tel_cliente = '" + txtagdtelefone.Text + "', ";
                    strsql += "CPF_cliente = '" + txtagdcpf.Text + "' ";
                    strsql += "where cod_cliente = " + txtagdid.Text;
                    comando.Connection = conexao;
                    comando.CommandText = strsql;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("registro alterado com sucesso!!!", "ADO.NET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //btnLimpar_Click(sender, e);
                }
                if (!leitor.IsClosed) { leitor.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro na alteração de dados ==> " + Erro.Message, "ADO.NET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }
        private void limpa_dados()
        {
            txtagdid.Clear();
            txtagdnome.Clear();
            txtagdtelefone.Clear();
            txtagdemail.Clear();
            txtagdcpf.Clear();
            txtagdid.Focus();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {

                string strsql = " select * from agenda where agdid = " + txtagdid.Text;
                comando.Connection = conexao;
                comando.CommandText = strsql;
                leitor = comando.ExecuteReader();
                if (!leitor.HasRows)
                {

                    MessageBox.Show("Registro não existe!!!", "Aviso");
                    limpa_dados();
                }
                else
                {
                    leitor.Read();
                    txtagdnome.Text = leitor["agdnome"].ToString();
                    txtagdemail.Text = leitor["agdemail"].ToString();
                    txtagdtelefone.Text = leitor["agdtelefone"].ToString();
                    txtagdcpf.Text = leitor["agdcpf"].ToString();
                    if (MessageBox.Show(" Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!leitor.IsClosed) { leitor.Close(); }

                        strsql = " Delete from agenda where agdid = " + txtagdid.Text;
                        comando.Connection = conexao;
                        comando.CommandText = strsql;
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Registro excluido com sucesso!!!", "Aviso");
                        if (!leitor.IsClosed) { leitor.Close(); }
                        limpa_dados();

                    }
                    else
                    {
                        limpa_dados();
                    }

                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro na exclusão dos dados ==> " + Erro.Message, "ADO.NET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            if (!leitor.IsClosed) { leitor.Close(); }
        }


        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = " select * from tb_cliente where CPF_cliente = '" + txtagdcpf.Text + "'";
                comando.Connection = conexao;
                comando.CommandText = strsql;
                leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    txtagdid.Text = leitor["cod_cliente"].ToString();
                    txtagdnome.Text = leitor["nome_cliente"].ToString();
                    txtagdemail.Text = leitor["email_cliente"].ToString();
                    txtagdtelefone.Text = leitor["tel_cliente"].ToString();
                    txtagdcpf.Text = leitor["CPF_cliente"].ToString();

                    btnalterar.Enabled = true;
                    btnexcluir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código inexistente!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtagdid.Clear();
                    txtagdid.Focus();

                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro na consulta ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (!leitor.IsClosed) { leitor.Close(); }
        }

        private void btnlistardados_Click(object sender, EventArgs e)
        {
            FrmConsultar consulta = new FrmConsultar();
            consulta.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtagdcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtagdtelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtagdemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtagdnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtagdid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }
    }
}


