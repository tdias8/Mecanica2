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
                comando = new MySqlCommand("INSERT INTO clientes (cpf,nome,telefone,email,endereco,dtnascimento,sexo,estadocivil,ativo)" +
                "VALUES(@cpf,@nome,@telefone,@email,@endereco,@dtnascimento,@sexo,@estadocivil,@ativo)", conexao);
                comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                comando.Parameters.AddWithValue("@nome", cliente.nome);
                comando.Parameters.AddWithValue("@telefone", cliente.telefone);
                comando.Parameters.AddWithValue("@email", cliente.email);
                comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                comando.Parameters.AddWithValue("@dtnascimento", cliente.dtnascimento);
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

        public DataTable listar()
        {

            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT*FROM clientes ORDER BY nome", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

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
            public void editar(Cliente cliente)
            {
                try
                {
                    AbrirConexao();
                    comando = new MySqlCommand("UPDATE clientes SET @cpf = cpf,@nome=nome,@telefone=telefone ,@email=email,@endereco=endereco,@dtnascimento=dtnascimento,@sexo=sexo,@estadocivilestadocivil,@ativo=ativo WHERE id = @id)", conexao);
                    comando.Parameters.AddWithValue("@id", cliente.id);
                    comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                    comando.Parameters.AddWithValue("@nome", cliente.nome);
                    comando.Parameters.AddWithValue("@telefone", cliente.telefone);
                    comando.Parameters.AddWithValue("@email", cliente.email);
                    comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                    comando.Parameters.AddWithValue("@dtnascimento", cliente.dtnascimento);
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
    }
}
