namespace PMBYOS
{
    partial class frmBuscarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbDepartamento = new System.Windows.Forms.RadioButton();
            this.dtgBuscarFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1113, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(129, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(361, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Por: ";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(556, 32);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(62, 20);
            this.rbNome.TabIndex = 4;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbDepartamento
            // 
            this.rbDepartamento.AutoSize = true;
            this.rbDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartamento.Location = new System.Drawing.Point(639, 32);
            this.rbDepartamento.Name = "rbDepartamento";
            this.rbDepartamento.Size = new System.Drawing.Size(119, 20);
            this.rbDepartamento.TabIndex = 5;
            this.rbDepartamento.TabStop = true;
            this.rbDepartamento.Text = "Departamento";
            this.rbDepartamento.UseVisualStyleBackColor = true;
            // 
            // dtgBuscarFuncionarios
            // 
            this.dtgBuscarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarFuncionarios.Location = new System.Drawing.Point(12, 93);
            this.dtgBuscarFuncionarios.Name = "dtgBuscarFuncionarios";
            this.dtgBuscarFuncionarios.Size = new System.Drawing.Size(963, 411);
            this.dtgBuscarFuncionarios.TabIndex = 6;
            this.dtgBuscarFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuscarFuncionarios_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(869, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 60);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBuscarFuncionario
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 516);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgBuscarFuncionarios);
            this.Controls.Add(this.rbDepartamento);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarFuncionario";
            this.Text = "Buscar Funcionários Cadastrados";
            this.Load += new System.EventHandler(this.frmBuscarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbDepartamento;
        private System.Windows.Forms.DataGridView dtgBuscarFuncionarios;
        private System.Windows.Forms.Button btnBuscar;
    }
}