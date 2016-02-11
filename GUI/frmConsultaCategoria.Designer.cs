namespace GUI
{
    partial class frmConsultaCategoria
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
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.DadosDataGridView = new System.Windows.Forms.DataGridView();
            this.LocalizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Location = new System.Drawing.Point(13, 13);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoriaLabel.TabIndex = 0;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(16, 30);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(683, 20);
            this.ValorTextBox.TabIndex = 1;
            // 
            // DadosDataGridView
            // 
            this.DadosDataGridView.AllowUserToAddRows = false;
            this.DadosDataGridView.AllowUserToDeleteRows = false;
            this.DadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DadosDataGridView.Location = new System.Drawing.Point(16, 65);
            this.DadosDataGridView.Name = "DadosDataGridView";
            this.DadosDataGridView.ReadOnly = true;
            this.DadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DadosDataGridView.Size = new System.Drawing.Size(764, 496);
            this.DadosDataGridView.TabIndex = 3;
            this.DadosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DadosDataGridView_CellDoubleClick);
            // 
            // LocalizarButton
            // 
            this.LocalizarButton.Location = new System.Drawing.Point(705, 30);
            this.LocalizarButton.Name = "LocalizarButton";
            this.LocalizarButton.Size = new System.Drawing.Size(75, 23);
            this.LocalizarButton.TabIndex = 2;
            this.LocalizarButton.Text = "Localizar";
            this.LocalizarButton.UseVisualStyleBackColor = true;
            this.LocalizarButton.Click += new System.EventHandler(this.LocalizarButton_Click);
            // 
            // frmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.DadosDataGridView);
            this.Controls.Add(this.LocalizarButton);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.CategoriaLabel);
            this.Name = "frmConsultaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.frmConsultaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Button LocalizarButton;
        private System.Windows.Forms.DataGridView DadosDataGridView;
    }
}