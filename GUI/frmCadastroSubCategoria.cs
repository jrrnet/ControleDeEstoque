using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmCadastroSubCategoria : GUI.frmModeloDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        // Botão Cancelar limpa todos os campos
        public void LimpaTela()
        {
            txtSubcatcod.Clear();
            txtNomeSubCategoria.Clear();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar(""); // Carrega no ComboBox os valores da Categoria
            cbCatCod.DisplayMember = "cat_nome"; 
            cbCatCod.ValueMember = "cat_cod";
        }

        // Inserir
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        // Cancelar e Limpa os campos            
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);            
        }

        // Botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {            
            try
            {
                // Leitura dos dados nos campos
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNomeSubCategoria.Text;
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);

                // Objeto para conexão e gravação no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    // Cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ScatCod.ToString());
                }
                else
                {
                    // Alterar uma categoria
                    modelo.ScatCod = Convert.ToInt32(txtSubcatcod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        // Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        // Botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtSubcatcod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        // Botão Localizar
        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtSubcatcod.Text = modelo.ScatCod.ToString();
                txtNomeSubCategoria.Text = modelo.ScatNome;
                cbCatCod.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();             
        }
    }
}
