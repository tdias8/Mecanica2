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
            listar();
        }

        private void salvar(Cliente cliente)
        {
            ClienteBLL clienteBLL = new ClienteBLL();

            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.telefone = txtFone.Text;
            cliente.email = txtEmail.Text;
            cliente.estadoCivil = txtEstadoCivil.Text;
            cliente.sexo = listsexo.Text;
            cliente.dtnascimento = dtNascimento.Text;
            cliente.ativo =panelSituacao. Text;

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

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listar()
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            dgDados.DataSource = clienteBLL.listar();
        }

        private void dgDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgDados.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = dgDados.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = dgDados.CurrentRow.Cells[4].Value.ToString();
            txtFone.Text = dgDados.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgDados.CurrentRow.Cells[2].Value.ToString();
            txtEstadoCivil.Text = dgDados.CurrentRow.Cells[8].Value.ToString();
            listsexo.Text = dgDados.CurrentRow.Cells[7].Value.ToString();
            dtNascimento.Text = dgDados.CurrentRow.Cells[6].Value.ToString();
            panelSituacao.Text = dgDados.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
