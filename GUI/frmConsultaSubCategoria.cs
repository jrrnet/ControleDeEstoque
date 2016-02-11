using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        // Botão Localizar
        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            LocalizarButton_Click(sender, e);
            DadosDataGridView.Columns[0].HeaderText = "Código da SubCategoria";
            DadosDataGridView.Columns[0].Width = 100;
            DadosDataGridView.Columns[1].HeaderText = "SubCategoria";
            DadosDataGridView.Columns[1].Width = 200;
            DadosDataGridView.Columns[2].HeaderText = "Código da Categoria";
            DadosDataGridView.Columns[2].Width = 100;
            DadosDataGridView.Columns[3].HeaderText = "Categoria";
            DadosDataGridView.Columns[3].Width = 200;
        }

        private void LocalizarButton_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            DadosDataGridView.DataSource = bll.Localizar(ValorTextBox.Text);        
        }

        private void DadosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(DadosDataGridView.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
