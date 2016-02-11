namespace GUI
{
    partial class frmCadastroSubCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigoSubCategoria = new System.Windows.Forms.Label();
            this.labelNomeSubCategoria = new System.Windows.Forms.Label();
            this.labelNomeCategoria = new System.Windows.Forms.Label();
            this.txtSubcatcod = new System.Windows.Forms.TextBox();
            this.txtNomeSubCategoria = new System.Windows.Forms.TextBox();
            this.cbCatCod = new System.Windows.Forms.ComboBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cbCatCod);
            this.pnDados.Controls.Add(this.txtNomeSubCategoria);
            this.pnDados.Controls.Add(this.txtSubcatcod);
            this.pnDados.Controls.Add(this.labelNomeCategoria);
            this.pnDados.Controls.Add(this.labelNomeSubCategoria);
            this.pnDados.Controls.Add(this.labelCodigoSubCategoria);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // labelCodigoSubCategoria
            // 
            this.labelCodigoSubCategoria.AutoSize = true;
            this.labelCodigoSubCategoria.Location = new System.Drawing.Point(10, 20);
            this.labelCodigoSubCategoria.Name = "labelCodigoSubCategoria";
            this.labelCodigoSubCategoria.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoSubCategoria.TabIndex = 0;
            this.labelCodigoSubCategoria.Text = "Código";
            // 
            // labelNomeSubCategoria
            // 
            this.labelNomeSubCategoria.AutoSize = true;
            this.labelNomeSubCategoria.Location = new System.Drawing.Point(10, 71);
            this.labelNomeSubCategoria.Name = "labelNomeSubCategoria";
            this.labelNomeSubCategoria.Size = new System.Drawing.Size(117, 13);
            this.labelNomeSubCategoria.TabIndex = 1;
            this.labelNomeSubCategoria.Text = "Nome da SubCategoria";
            // 
            // labelNomeCategoria
            // 
            this.labelNomeCategoria.AutoSize = true;
            this.labelNomeCategoria.Location = new System.Drawing.Point(9, 124);
            this.labelNomeCategoria.Name = "labelNomeCategoria";
            this.labelNomeCategoria.Size = new System.Drawing.Size(98, 13);
            this.labelNomeCategoria.TabIndex = 2;
            this.labelNomeCategoria.Text = "Nome da Categoria";
            // 
            // txtSubcatcod
            // 
            this.txtSubcatcod.Enabled = false;
            this.txtSubcatcod.Location = new System.Drawing.Point(13, 36);
            this.txtSubcatcod.Name = "txtSubcatcod";
            this.txtSubcatcod.Size = new System.Drawing.Size(100, 20);
            this.txtSubcatcod.TabIndex = 3;
            // 
            // txtNomeSubCategoria
            // 
            this.txtNomeSubCategoria.Location = new System.Drawing.Point(13, 88);
            this.txtNomeSubCategoria.Name = "txtNomeSubCategoria";
            this.txtNomeSubCategoria.Size = new System.Drawing.Size(736, 20);
            this.txtNomeSubCategoria.TabIndex = 4;
            // 
            // cbCatCod
            // 
            this.cbCatCod.FormattingEnabled = true;
            this.cbCatCod.Location = new System.Drawing.Point(12, 141);
            this.cbCatCod.Name = "cbCatCod";
            this.cbCatCod.Size = new System.Drawing.Size(364, 21);
            this.cbCatCod.TabIndex = 5;
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "Cadastro de SubCategoria";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCatCod;
        private System.Windows.Forms.TextBox txtNomeSubCategoria;
        private System.Windows.Forms.TextBox txtSubcatcod;
        private System.Windows.Forms.Label labelNomeCategoria;
        private System.Windows.Forms.Label labelNomeSubCategoria;
        private System.Windows.Forms.Label labelCodigoSubCategoria;
    }
}
