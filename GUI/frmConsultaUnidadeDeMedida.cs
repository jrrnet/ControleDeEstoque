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
    public partial class frmConsultaUnidadeDeMedida : Form
    {
        public int codigo = 0;

        public frmConsultaUnidadeDeMedida()
        {
            InitializeComponent();
        }

        private void LocalizarButton_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
            DadosDataGridView.DataSource = bll.Localizar(ValorTextBox.Text);
        }

        private void frmConsultaUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            LocalizarButton_Click(sender, e);
            DadosDataGridView.Columns[0].HeaderText = "Código";
            DadosDataGridView.Columns[0].Width = 50;
            DadosDataGridView.Columns[1].HeaderText = "Unidade de Medida";
            DadosDataGridView.Columns[1].Width = 700;
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
