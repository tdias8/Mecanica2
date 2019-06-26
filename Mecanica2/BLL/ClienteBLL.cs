using System;
using System.Collections.Generic;
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

        public void listar (Cliente cliente)
        {
            try
            {
                clienteDAO.listar(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
