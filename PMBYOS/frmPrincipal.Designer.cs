namespace PMBYOS
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsBtnFuncionarios = new System.Windows.Forms.ToolStripSplitButton();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnOrdens = new System.Windows.Forms.ToolStripSplitButton();
            this.visualizarOrdensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emAndamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEquip = new System.Windows.Forms.ToolStripSplitButton();
            this.cadastrarEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEquipamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPecas = new System.Windows.Forms.ToolStripSplitButton();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtntecnicos = new System.Windows.Forms.ToolStripSplitButton();
            this.cadastrarTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarTécnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnFornecedores = new System.Windows.Forms.ToolStripSplitButton();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.novaEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLblHora = new System.Windows.Forms.ToolStripLabel();
            this.lblInfoUser = new System.Windows.Forms.ToolStripLabel();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.dtgAviso = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAviso = new System.Windows.Forms.Button();
            this.updateForm = new System.Windows.Forms.Timer(this.components);
            this.tsPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFuncionarios,
            this.toolStripSeparator1,
            this.tsBtnOrdens,
            this.toolStripSeparator2,
            this.tsBtnEquip,
            this.toolStripSeparator3,
            this.tsBtnPecas,
            this.toolStripSeparator4,
            this.tsBtntecnicos,
            this.toolStripSeparator5,
            this.tsBtnFornecedores,
            this.toolStripSeparator6,
            this.toolStripSplitButton1});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(1019, 39);
            this.tsPrincipal.TabIndex = 0;
            this.tsPrincipal.Text = "toolStrip1";
            // 
            // tsBtnFuncionarios
            // 
            this.tsBtnFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarFuncionáriosToolStripMenuItem});
            this.tsBtnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFuncionarios.Image")));
            this.tsBtnFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFuncionarios.Name = "tsBtnFuncionarios";
            this.tsBtnFuncionarios.Size = new System.Drawing.Size(101, 36);
            this.tsBtnFuncionarios.Text = "Funcionários";
            this.tsBtnFuncionarios.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsBtnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnFuncionarios.ButtonClick += new System.EventHandler(this.tsBtnFuncionarios_ButtonClick);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar funcionário";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.editarToolStripMenuItem.Text = "Editar funcionário";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // buscarFuncionáriosToolStripMenuItem
            // 
            this.buscarFuncionáriosToolStripMenuItem.Name = "buscarFuncionáriosToolStripMenuItem";
            this.buscarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buscarFuncionáriosToolStripMenuItem.Text = "Buscar Funcionários";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnOrdens
            // 
            this.tsBtnOrdens.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarOrdensToolStripMenuItem});
            this.tsBtnOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnOrdens.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOrdens.Image")));
            this.tsBtnOrdens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOrdens.Name = "tsBtnOrdens";
            this.tsBtnOrdens.Size = new System.Drawing.Size(68, 36);
            this.tsBtnOrdens.Text = "Ordens";
            this.tsBtnOrdens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnOrdens.ButtonClick += new System.EventHandler(this.tsBtnOrdens_ButtonClick_1);
            // 
            // visualizarOrdensToolStripMenuItem
            // 
            this.visualizarOrdensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emAndamentoToolStripMenuItem,
            this.finalizadasToolStripMenuItem});
            this.visualizarOrdensToolStripMenuItem.Name = "visualizarOrdensToolStripMenuItem";
            this.visualizarOrdensToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.visualizarOrdensToolStripMenuItem.Text = "Visualizar ordens";
            // 
            // emAndamentoToolStripMenuItem
            // 
            this.emAndamentoToolStripMenuItem.Name = "emAndamentoToolStripMenuItem";
            this.emAndamentoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.emAndamentoToolStripMenuItem.Text = "Em andamento";
            this.emAndamentoToolStripMenuItem.Click += new System.EventHandler(this.emAndamentoToolStripMenuItem_Click);
            // 
            // finalizadasToolStripMenuItem
            // 
            this.finalizadasToolStripMenuItem.Name = "finalizadasToolStripMenuItem";
            this.finalizadasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.finalizadasToolStripMenuItem.Text = "Finalizadas";
            this.finalizadasToolStripMenuItem.Click += new System.EventHandler(this.finalizadasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnEquip
            // 
            this.tsBtnEquip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEquipamentoToolStripMenuItem,
            this.editarEquipamentoToolStripMenuItem,
            this.visualizarEquipamentoToolStripMenuItem});
            this.tsBtnEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnEquip.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEquip.Image")));
            this.tsBtnEquip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEquip.Name = "tsBtnEquip";
            this.tsBtnEquip.Size = new System.Drawing.Size(111, 36);
            this.tsBtnEquip.Text = "Equipamentos";
            this.tsBtnEquip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnEquip.ButtonClick += new System.EventHandler(this.tsBtnEquip_ButtonClick);
            // 
            // cadastrarEquipamentoToolStripMenuItem
            // 
            this.cadastrarEquipamentoToolStripMenuItem.Name = "cadastrarEquipamentoToolStripMenuItem";
            this.cadastrarEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarEquipamentoToolStripMenuItem.Text = "Cadastrar equipamento";
            this.cadastrarEquipamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEquipamentoToolStripMenuItem_Click);
            // 
            // editarEquipamentoToolStripMenuItem
            // 
            this.editarEquipamentoToolStripMenuItem.Name = "editarEquipamentoToolStripMenuItem";
            this.editarEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.editarEquipamentoToolStripMenuItem.Text = "Editar equipamento";
            this.editarEquipamentoToolStripMenuItem.Click += new System.EventHandler(this.editarEquipamentoToolStripMenuItem_Click);
            // 
            // visualizarEquipamentoToolStripMenuItem
            // 
            this.visualizarEquipamentoToolStripMenuItem.Name = "visualizarEquipamentoToolStripMenuItem";
            this.visualizarEquipamentoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.visualizarEquipamentoToolStripMenuItem.Text = "Buscar equipamento";
            this.visualizarEquipamentoToolStripMenuItem.Click += new System.EventHandler(this.visualizarEquipamentoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnPecas
            // 
            this.tsBtnPecas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.visualizarEstoqueToolStripMenuItem});
            this.tsBtnPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnPecas.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPecas.Image")));
            this.tsBtnPecas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPecas.Name = "tsBtnPecas";
            this.tsBtnPecas.Size = new System.Drawing.Size(63, 36);
            this.tsBtnPecas.Text = "Peças";
            this.tsBtnPecas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPecas.ButtonClick += new System.EventHandler(this.tsBtnPecas_ButtonClick);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.visualizarToolStripMenuItem.Text = "Cadastrar peça";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            this.visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            this.visualizarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.visualizarEstoqueToolStripMenuItem.Text = "Visualizar estoque";
            this.visualizarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.visualizarEstoqueToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtntecnicos
            // 
            this.tsBtntecnicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTécnicoToolStripMenuItem,
            this.visualizarTécnicosToolStripMenuItem});
            this.tsBtntecnicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtntecnicos.Image = ((System.Drawing.Image)(resources.GetObject("tsBtntecnicos.Image")));
            this.tsBtntecnicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtntecnicos.Name = "tsBtntecnicos";
            this.tsBtntecnicos.Size = new System.Drawing.Size(80, 36);
            this.tsBtntecnicos.Text = "Técnicos";
            this.tsBtntecnicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtntecnicos.ButtonClick += new System.EventHandler(this.tsBtntecnicos_ButtonClick);
            // 
            // cadastrarTécnicoToolStripMenuItem
            // 
            this.cadastrarTécnicoToolStripMenuItem.Name = "cadastrarTécnicoToolStripMenuItem";
            this.cadastrarTécnicoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastrarTécnicoToolStripMenuItem.Text = "Cadastrar técnico";
            this.cadastrarTécnicoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTécnicoToolStripMenuItem_Click);
            // 
            // visualizarTécnicosToolStripMenuItem
            // 
            this.visualizarTécnicosToolStripMenuItem.Name = "visualizarTécnicosToolStripMenuItem";
            this.visualizarTécnicosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.visualizarTécnicosToolStripMenuItem.Text = "Visualizar técnicos";
            this.visualizarTécnicosToolStripMenuItem.Click += new System.EventHandler(this.visualizarTécnicosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnFornecedores
            // 
            this.tsBtnFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem,
            this.visualizarFornecedoresToolStripMenuItem});
            this.tsBtnFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFornecedores.Image")));
            this.tsBtnFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFornecedores.Name = "tsBtnFornecedores";
            this.tsBtnFornecedores.Size = new System.Drawing.Size(109, 36);
            this.tsBtnFornecedores.Text = "Fornecedores";
            this.tsBtnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnFornecedores.ButtonClick += new System.EventHandler(this.tsBtnFornecedores_ButtonClick);
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            this.cadastrarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedorToolStripMenuItem_Click);
            // 
            // visualizarFornecedoresToolStripMenuItem
            // 
            this.visualizarFornecedoresToolStripMenuItem.Name = "visualizarFornecedoresToolStripMenuItem";
            this.visualizarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.visualizarFornecedoresToolStripMenuItem.Text = "Visualizar fornecedores";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaEntradaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(74, 36);
            this.toolStripSplitButton1.Text = "Estoque";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // novaEntradaToolStripMenuItem
            // 
            this.novaEntradaToolStripMenuItem.Name = "novaEntradaToolStripMenuItem";
            this.novaEntradaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novaEntradaToolStripMenuItem.Text = "Nova Entrada";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblHora,
            this.lblInfoUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLblHora
            // 
            this.tsLblHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblHora.BackColor = System.Drawing.Color.White;
            this.tsLblHora.Image = ((System.Drawing.Image)(resources.GetObject("tsLblHora.Image")));
            this.tsLblHora.Name = "tsLblHora";
            this.tsLblHora.Size = new System.Drawing.Size(97, 22);
            this.tsLblHora.Text = "Carregando ...";
            this.tsLblHora.Click += new System.EventHandler(this.tsLblHora_Click);
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Image = ((System.Drawing.Image)(resources.GetObject("lblInfoUser.Image")));
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(63, 22);
            this.lblInfoUser.Text = "Usuário";
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // dtgAviso
            // 
            this.dtgAviso.AllowUserToAddRows = false;
            this.dtgAviso.AllowUserToDeleteRows = false;
            this.dtgAviso.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgAviso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAviso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.avisos});
            this.dtgAviso.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgAviso.Location = new System.Drawing.Point(643, 66);
            this.dtgAviso.Name = "dtgAviso";
            this.dtgAviso.ReadOnly = true;
            this.dtgAviso.Size = new System.Drawing.Size(364, 344);
            this.dtgAviso.TabIndex = 2;
            this.dtgAviso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // avisos
            // 
            this.avisos.HeaderText = "Aviso";
            this.avisos.Name = "avisos";
            this.avisos.ReadOnly = true;
            this.avisos.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quadro de Avisos:";
            // 
            // btnAviso
            // 
            this.btnAviso.Enabled = false;
            this.btnAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAviso.Image = ((System.Drawing.Image)(resources.GetObject("btnAviso.Image")));
            this.btnAviso.Location = new System.Drawing.Point(923, 416);
            this.btnAviso.Name = "btnAviso";
            this.btnAviso.Size = new System.Drawing.Size(84, 29);
            this.btnAviso.TabIndex = 4;
            this.btnAviso.Text = "Adicionar";
            this.btnAviso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAviso.UseVisualStyleBackColor = true;
            this.btnAviso.Click += new System.EventHandler(this.btnAviso_Click);
            // 
            // updateForm
            // 
            this.updateForm.Interval = 1000;
            this.updateForm.Tick += new System.EventHandler(this.updateForm_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1019, 533);
            this.Controls.Add(this.btnAviso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAviso);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsPrincipal);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema OS";
            this.Activated += new System.EventHandler(this.frmPrincipal_Load);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPrincipal_Load);
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripSplitButton tsBtnFuncionarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsBtnOrdens;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tsBtnEquip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton tsBtnPecas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton tsBtntecnicos;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarOrdensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emAndamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEquipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEquipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton tsBtnFornecedores;
        private System.Windows.Forms.ToolStripMenuItem visualizarEquipamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarTécnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsLblHora;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.ToolStripMenuItem buscarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem novaEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblInfoUser;
        private System.Windows.Forms.DataGridView dtgAviso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAviso;
        private System.Windows.Forms.Timer updateForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn avisos;
    }
}