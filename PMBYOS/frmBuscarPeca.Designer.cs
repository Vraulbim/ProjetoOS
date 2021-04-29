namespace PMBYOS
{
    partial class frmBuscarPeca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.nbQtd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbGrupo = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar: ";
            // 
            // txtPeca
            // 
            this.txtPeca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeca.Location = new System.Drawing.Point(92, 25);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(378, 23);
            this.txtPeca.TabIndex = 1;
            // 
            // nbQtd
            // 
            this.nbQtd.Location = new System.Drawing.Point(123, 72);
            this.nbQtd.Name = "nbQtd";
            this.nbQtd.Size = new System.Drawing.Size(48, 20);
            this.nbQtd.TabIndex = 2;
            this.nbQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade: ";
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Checked = true;
            this.rbDescricao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescricao.Location = new System.Drawing.Point(687, 28);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(90, 20);
            this.rbDescricao.TabIndex = 4;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            // 
            // rbGrupo
            // 
            this.rbGrupo.AutoSize = true;
            this.rbGrupo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrupo.Location = new System.Drawing.Point(602, 28);
            this.rbGrupo.Name = "rbGrupo";
            this.rbGrupo.Size = new System.Drawing.Size(64, 20);
            this.rbGrupo.TabIndex = 5;
            this.rbGrupo.Text = "Grupo";
            this.rbGrupo.UseVisualStyleBackColor = true;
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFornecedor.Location = new System.Drawing.Point(487, 26);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(100, 20);
            this.rbFornecedor.TabIndex = 6;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 292);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(583, 410);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(194, 28);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmBuscarPeca
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbFornecedor);
            this.Controls.Add(this.rbGrupo);
            this.Controls.Add(this.rbDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbQtd);
            this.Controls.Add(this.txtPeca);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Peças em Estoque";
            this.Load += new System.EventHandler(this.frmBuscarPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.NumericUpDown nbQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbGrupo;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
    }
}