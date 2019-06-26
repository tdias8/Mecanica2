using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Mecanica2.DAO
{
    public class ClienteDAO : Conexao
    {
        Cliente cliente = new Cliente();
        MySqlCommand comando = null;
        public void salvar(Cliente cliente)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO pessoa (cpf,nome,fone,email,tipopessoa,endereco,dtnascimento,sexo,estadocivil,ativo)"+
                "VALUES(@cpf,@nome,@fone,@email, 1 ,@endereco,@dtnascimento,@sexo,@estadocivil,@ativo)",conexao);
                comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                comando.Parameters.AddWithValue("@nome", cliente.nome);
                comando.Parameters.AddWithValue("@fone", cliente.fone);
                comando.Parameters.AddWithValue("@email", cliente.email);
                comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                comando.Parameters.AddWithValue("@dtnascimento", cliente.dtNascimento);
                comando.Parameters.AddWithValue("@sexo", cliente.sexo);
                comando.Parameters.AddWithValue("@estadocivil", cliente.estadoCivil);
                comando.Parameters.AddWithValue("@ativo", cliente.ativo);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void  listar(Cliente cliente)
        {
      
            try
            {
                AbrirConexao();
                MySqlDataReader dr = comando.ExecuteReader();

                comando = new MySqlCommand("SELECT*FROM pessoa ORDER BY id", conexao);
              
            }
            catch(Exception erro){
                throw erro;
            }

           
        }
    }
}
