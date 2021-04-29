namespace PMBYOS
{
    partial class frmBuscarOs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarOs));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRequisitante = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbTecnico = new System.Windows.Forms.RadioButton();
            this.dtBuscarOs = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuscarOs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(73, 11);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(285, 23);
            this.txtBusca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Por: ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbRequisitante
            // 
            this.rbRequisitante.AutoSize = true;
            this.rbRequisitante.Checked = true;
            this.rbRequisitante.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRequisitante.Location = new System.Drawing.Point(410, 12);
            this.rbRequisitante.Name = "rbRequisitante";
            this.rbRequisitante.Size = new System.Drawing.Size(107, 20);
            this.rbRequisitante.TabIndex = 2;
            this.rbRequisitante.TabStop = true;
            this.rbRequisitante.Text = "Requisitante";
            this.rbRequisitante.UseVisualStyleBackColor = true;
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbData.Location = new System.Drawing.Point(535, 12);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(57, 20);
            this.rbData.TabIndex = 3;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // rbTecnico
            // 
            this.rbTecnico.AutoSize = true;
            this.rbTecnico.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTecnico.Location = new System.Drawing.Point(607, 12);
            this.rbTecnico.Name = "rbTecnico";
            this.rbTecnico.Size = new System.Drawing.Size(78, 20);
            this.rbTecnico.TabIndex = 4;
            this.rbTecnico.Text = "Técnico";
            this.rbTecnico.UseVisualStyleBackColor = true;
            // 
            // dtBuscarOs
            // 
            this.dtBuscarOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBuscarOs.Location = new System.Drawing.Point(12, 100);
            this.dtBuscarOs.Name = "dtBuscarOs";
            this.dtBuscarOs.Size = new System.Drawing.Size(776, 324);
            this.dtBuscarOs.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(635, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 56);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscarOs
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtBuscarOs);
            this.Controls.Add(this.rbTecnico);
            this.Controls.Add(this.rbData);
            this.Controls.Add(this.rbRequisitante);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar uma Ordem ";
            this.Load += new System.EventHandler(this.frmBuscarOs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBuscarOs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRequisitante;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbTecnico;
        private System.Windows.Forms.DataGridView dtBuscarOs;
        private System.Windows.Forms.Button btnBuscar;
    }
}