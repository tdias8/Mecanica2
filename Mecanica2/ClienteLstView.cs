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
    public partial class ClienteLstView : Form
    {
        public ClienteLstView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteView cliente = new ClienteView();
            cliente.Show();
        }

        private void ClienteLstView_Load(object sender, EventArgs e)
        {

        }

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteBLL clienteBLL = new ClienteBLL();

            ListViewItem lvi = new ListViewItem (cliente)
    

          
        }
    }
}
