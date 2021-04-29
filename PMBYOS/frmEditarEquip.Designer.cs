
namespace PMBYOS
{
    partial class frmEditarEquip
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFiltar = new System.Windows.Forms.Label();
            this.lBoxFiltrar = new System.Windows.Forms.ListBox();
            this.txtBoxBuscarEq = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(28, 66);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(160, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar equipamento:";
            // 
            // lblFiltar
            // 
            this.lblFiltar.AutoSize = true;
            this.lblFiltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltar.Location = new System.Drawing.Point(28, 24);
            this.lblFiltar.Name = "lblFiltar";
            this.lblFiltar.Size = new System.Drawing.Size(80, 20);
            this.lblFiltar.TabIndex = 1;
            this.lblFiltar.Text = "Filtrar por:";
            // 
            // lBoxFiltrar
            // 
            this.lBoxFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxFiltrar.FormattingEnabled = true;
            this.lBoxFiltrar.ItemHeight = 20;
            this.lBoxFiltrar.Items.AddRange(new object[] {
            "Número de série",
            "Patrimonio\t"});
            this.lBoxFiltrar.Location = new System.Drawing.Point(114, 24);
            this.lBoxFiltrar.Name = "lBoxFiltrar";
            this.lBoxFiltrar.Size = new System.Drawing.Size(147, 24);
            this.lBoxFiltrar.TabIndex = 2;
            // 
            // txtBoxBuscarEq
            // 
            this.txtBoxBuscarEq.Location = new System.Drawing.Point(194, 66);
            this.txtBoxBuscarEq.Name = "txtBoxBuscarEq";
            this.txtBoxBuscarEq.Size = new System.Drawing.Size(279, 22);
            this.txtBoxBuscarEq.TabIndex = 3;
            this.txtBoxBuscarEq.TextChanged += new System.EventHandler(this.txtBoxBuscarEq_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 350);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(137, 103);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(86, 30);
            this.btnconfirmar.TabIndex = 5;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // frmEditarEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 509);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxBuscarEq);
            this.Controls.Add(this.lBoxFiltrar);
            this.Controls.Add(this.lblFiltar);
            this.Controls.Add(this.lblBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditarEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar equipamento";
            this.Load += new System.EventHandler(this.frmEditarEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFiltar;
        private System.Windows.Forms.ListBox lBoxFiltrar;
        private System.Windows.Forms.TextBox txtBoxBuscarEq;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnconfirmar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}