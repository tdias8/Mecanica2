using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mecanica2.DAO;

namespace Mecanica2.BLL
{
    public class ClienteBLL
    {
        ClienteDAO clienteDAO = new ClienteDAO();

        public void salvar (Cliente cliente)
        {
            try
            {
                clienteDAO.salvar(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        public DataTable listar ()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = clienteDAO.listar();

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
