namespace PMBYOS
{
    partial class frmBuscarTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarTecnico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.btnBuscarTec = new System.Windows.Forms.Button();
            this.dtgTecnicos = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTecnicos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(146, 31);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(452, 23);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar: ";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(622, 32);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(62, 20);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTelefone.Location = new System.Drawing.Point(704, 32);
            this.rbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(83, 20);
            this.rbTelefone.TabIndex = 3;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone";
            this.rbTelefone.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTec
            // 
            this.btnBuscarTec.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTec.Image")));
            this.btnBuscarTec.Location = new System.Drawing.Point(823, 12);
            this.btnBuscarTec.Name = "btnBuscarTec";
            this.btnBuscarTec.Size = new System.Drawing.Size(105, 84);
            this.btnBuscarTec.TabIndex = 4;
            this.btnBuscarTec.Text = "Buscar";
            this.btnBuscarTec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarTec.UseVisualStyleBackColor = true;
            this.btnBuscarTec.Click += new System.EventHandler(this.btnBuscarTec_Click);
            this.btnBuscarTec.Leave += new System.EventHandler(this.frmBuscarTecnico_Load);
            // 
            // dtgTecnicos
            // 
            this.dtgTecnicos.AllowUserToAddRows = false;
            this.dtgTecnicos.AllowUserToDeleteRows = false;
            this.dtgTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTecnicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.telefone,
            this.endereco,
            this.is_admin});
            this.dtgTecnicos.Location = new System.Drawing.Point(12, 102);
            this.dtgTecnicos.Name = "dtgTecnicos";
            this.dtgTecnicos.ReadOnly = true;
            this.dtgTecnicos.RowTemplate.ReadOnly = true;
            this.dtgTecnicos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTecnicos.Size = new System.Drawing.Size(916, 416);
            this.dtgTecnicos.TabIndex = 5;
            this.dtgTecnicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTecnicos_CellContentClick);
            this.dtgTecnicos.SelectionChanged += new System.EventHandler(this.dtgTecnicos_SelectionChanged);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 30;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // telefone
            // 
            dataGridViewCellStyle1.Format = "(99)9999-9999";
            dataGridViewCellStyle1.NullValue = null;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle1;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 180;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 340;
            // 
            // is_admin
            // 
            this.is_admin.HeaderText = "Administrador";
            this.is_admin.Name = "is_admin";
            this.is_admin.ReadOnly = true;
            this.is_admin.Width = 108;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(672, 59);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpar Seleção";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.frmBuscarTecnico_Load);
            // 
            // frmBuscarTecnico
            // 
            this.AcceptButton = this.btnBuscarTec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 530);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtgTecnicos);
            this.Controls.Add(this.btnBuscarTec);
            this.Controls.Add(this.rbTelefone);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarTecnico";
            this.Text = "Buscar um Técnico";
            this.Load += new System.EventHandler(this.frmBuscarTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTecnicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.Button btnBuscarTec;
        private System.Windows.Forms.DataGridView dtgTecnicos;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_admin;
    }
}