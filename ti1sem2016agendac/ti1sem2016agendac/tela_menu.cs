using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ti1sem2016agendac
{
    public partial class tela_menu : Form
    {
        public tela_menu()
        {
            InitializeComponent();
        }

        private void tela_menu_Load(object sender, EventArgs e)
        {
            logarToolStripMenuItem.Text = "Logout";
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
            tela_agendamento agenda = new tela_agendamento();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_cadastroCliente cadcli = new tela_cadastroCliente();
            cadcli.MdiParent = this;
            
            cadcli.Show();
            //cadcli.btnincluir.visible = false
                
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela_serviço serviço = new tela_serviço();
            serviço.MdiParent = this;
            serviço.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin login_cad = new frmlogin();
            login_cad.MdiParent = this;
            login_cad.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela_produto produto = new tela_produto();
            produto.MdiParent = this;
            produto.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_venda produto = new tela_venda();
            produto.MdiParent = this;
            produto.Show();
        
        }
    }
}
