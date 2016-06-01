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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao = new MySqlConnection();
        private MySqlCommand comando = new MySqlCommand();
        private MySqlDataReader leitor;


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
             {
            try
            {
                string strsql = " select * from tb_cliente where nome_cliente like '"+ txtagdid.Text + "%' order by nome_cliente";
                comando.Connection = conexao;
                comando.CommandText = strsql;
                leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    listBox1.Items.Clear();
                    dataGridView1.Rows.Clear();


                   while (leitor.Read())
                    {

                    dataGridView1.Rows.Add(leitor["cod_cliente"].ToString(), leitor["nome_cliente"].ToString(), leitor["tel_cliente"].ToString(), leitor["CPF_cliente"].ToString());
                    listBox1.Items.Add (leitor["nome_cliente"].ToString());
                   
                    
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

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
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

    }
}
