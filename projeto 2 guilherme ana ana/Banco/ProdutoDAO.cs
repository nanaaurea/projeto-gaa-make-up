using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_2_guilherme_ana_ana.Banco
{
    public static class ProdutoDAO
    {
        public static object EasyEncryption { get; private set; }

        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM produtos";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }


        public static bool Cadastrar(Produtos p)
        {
            string comando;
            comando = "INSERT INTO produtos (" +
                "nome_produto, fornecedor, categoria, preco, estoque) VALUES " +
                "(@nome_produto, @fornecedor, @categoria, @preco, @estoque"
                + ")";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();




            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_produto", p.Produto);
            cmd.Parameters.AddWithValue("@fornecedor", p.fornecedor);
            cmd.Parameters.AddWithValue("@categoria", p.categoria);
            cmd.Parameters.AddWithValue("@preco", p.preco);
            cmd.Parameters.AddWithValue("@estoque", p.estoque);

            cmd.Prepare();

            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;
            }
            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }
            //try
            //{

            //}
            //catch
            //{
            //    return false;
            //}




        }



        public static bool Modificar(Produtos p)
        {


            string comando;

            comando = "UPDATE produtos " +
           "SET nome_produto = @nome_produto, " +
           "fornecedor = @fornecedor, " +
           "categoria = @categoria, " +
           "preco = @preco, " +
           "estoque = @estoque " +
           "WHERE id = @id";


            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_produto", p.Produto);
            cmd.Parameters.AddWithValue("@fornecedor", p.fornecedor);
            cmd.Parameters.AddWithValue("@categoria", p.categoria);
            cmd.Parameters.AddWithValue("@preco", p.preco);
            cmd.Parameters.AddWithValue("@estoque", p.estoque);
            cmd.Parameters.AddWithValue("@id", p.id);



            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }


        }
        public static bool ApagarPorID(int id)
        {
            string comando;
            comando = "DELETE FROM produtos WHERE id = @id";


            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id);


            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
    

    }
}
    

