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
    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        // Incluir
        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO subcategoria(cat_cod, scat_nome) VALUES (@catcod, @nome); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                conexao.Conectar();
                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar());           
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
        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE subcategoria SET scat_nome = @nome, cat_cod = @catcod WHERE scat_cod = @scatcod;";
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
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
                cmd.CommandText = "DELETE FROM subcategoria WHERE scat_cod = @codigo;";
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome FROM subcategoria sc INNER JOIN categoria c ON sc.cat_cod = c.cat_cod WHERE scat_nome LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // Carrega Modelo
        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {            
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM subcategoria WHERE scat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
                modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);                
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}








