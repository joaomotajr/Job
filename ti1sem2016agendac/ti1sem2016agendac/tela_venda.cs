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
    public partial class tela_venda : Form
    {
        public tela_venda()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao = new MySqlConnection();
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader leitor;

        private void btnlistardados_Click(object sender, EventArgs e)
        {

        }

        private void txtagdnome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string strsql = " select * from tb_cliente where nome_cliente like '" + txtagdid.Text + "%' order by nome_cliente";
                comando.Connection = conexao;
                comando.CommandText = strsql;
                leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    listBox1.Items.Clear();
                    


                    while (leitor.Read())
                    {

                       
                        listBox1.Items.Add(leitor["agdnome"].ToString());
                        // txtagdnome.Text = leitor["agdnome"].ToString();

                    }
                }

                else
                {
                    MessageBox.Show("Nome inexistente!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tela_venda_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.ConnectionString = "server=localhost;Database = invictus;UID=root;PWD =;Port=3306";

                conexao.Open();
                
                try
                {
                    string strsql = " select * from carro order by nome";
                    comando.Connection = conexao;
                    comando.CommandText = strsql;
                    leitor = comando.ExecuteReader();
                    if (leitor.HasRows)
                    {
                        
                       listBox2.Items.Clear();
                       
                        while (leitor.Read())
                        {

                            comboBox1.Items.Add(leitor["nome"].ToString() + "   " + leitor["tipo"].ToString() + "   " + leitor["ano"].ToString() + "   " + leitor["cor"].ToString());

                        }
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

            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }
    }
}
