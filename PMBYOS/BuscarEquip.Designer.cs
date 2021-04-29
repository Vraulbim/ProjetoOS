
namespace PMBYOS
{
    partial class frmBuscarEquip
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
            this.lblBusca = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lBoxFiltro = new System.Windows.Forms.ListBox();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(12, 42);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(63, 20);
            this.lblBusca.TabIndex = 0;
            this.lblBusca.Text = "Buscar:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(551, 42);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(80, 20);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // lBoxFiltro
            // 
            this.lBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxFiltro.FormattingEnabled = true;
            this.lBoxFiltro.ItemHeight = 20;
            this.lBoxFiltro.Items.AddRange(new object[] {
            "Tudo",
            "Número de série",
            "Patrimonio",
            "Grupo",
            "Sub grupo",
            "Fornecedor",
            "Departamento\t"});
            this.lBoxFiltro.Location = new System.Drawing.Point(637, 42);
            this.lBoxFiltro.Name = "lBoxFiltro";
            this.lBoxFiltro.Size = new System.Drawing.Size(140, 24);
            this.lBoxFiltro.TabIndex = 2;
            this.lBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.lBoxFiltro_SelectedIndexChanged);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(81, 42);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(386, 22);
            this.txtBoxBuscar.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1039, 403);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(286, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 36);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Confirmar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscarEquip
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lBoxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblBusca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBuscarEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar equipamento";
            this.Load += new System.EventHandler(this.frmBuscarEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ListBox lBoxFiltro;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
    }
}