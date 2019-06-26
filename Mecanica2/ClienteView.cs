using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mecanica2.BLL;
using Mecanica2.DAO;
namespace Mecanica2
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
        }

        private void salvar(Cliente cliente)
        {
            ClienteBLL clienteBLL = new ClienteBLL();

            cliente.nome = txtNome.Text;
            cliente.cpf = txtNome.Text;
            cliente.endereco = txtNome.Text;
            cliente.fone = txtNome.Text;
            cliente.email = txtNome.Text;
            cliente.estadoCivil = txtNome.Text;
            cliente.sexo = listsexo.Text;
            cliente.dtNascimento = txtNome.Text;
            cliente.ativo = panelSituacao.Text;

            clienteBLL.salvar(cliente);
            MessageBox.Show("Salvo com sucesso");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            salvar(cliente);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClienteView_Load(object sender, EventArgs e)
        {

        }
    }
}
