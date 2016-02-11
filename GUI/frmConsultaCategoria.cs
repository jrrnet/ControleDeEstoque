using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        // Botão Localizar
        private void LocalizarButton_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            DadosDataGridView.DataSource = bll.Localizar(ValorTextBox.Text);
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            LocalizarButton_Click(sender, e);
            DadosDataGridView.Columns[0].HeaderText = "Código da SubCategoria";
            DadosDataGridView.Columns[0].Width = 80;
            DadosDataGridView.Columns[1].HeaderText = "SubCategoria";
            DadosDataGridView.Columns[1].Width = 550;
        }

        // Duplo Click no DataGridView
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