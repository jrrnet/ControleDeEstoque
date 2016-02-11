using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelo;


namespace DAL
{
    public class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        // Incluir
        public void Incluir(ModeloCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO categoria(cat_nome) VALUES (@nome); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
                conexao.Conectar();
                modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());           
            }
            catch (Exception erro)
            {
                
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        // Alterar
        public void Alterar(ModeloCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE categoria SET cat_nome = @nome WHERE cat_cod = @codigo;";
                cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);

                conexao.Conectar();
                cmd.ExecuteNonQuery();                
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }            
        }

        // Excluir
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM categoria WHERE cat_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();            
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }            
        }

        // Localizar
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM categoria WHERE cat_nome LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // Carrega Modelo
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM categoria WHERE cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
