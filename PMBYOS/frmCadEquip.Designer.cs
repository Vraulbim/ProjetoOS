
namespace PMBYOS
{
    partial class frmCadEquip
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
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblSubGrupo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblPatri = new System.Windows.Forms.Label();
            this.lblForn = new System.Windows.Forms.Label();
            this.lblDataAq = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.mTxtBoxData = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxGrupo = new System.Windows.Forms.TextBox();
            this.txtBoxSubGrupo = new System.Windows.Forms.TextBox();
            this.txtBoxNSerie = new System.Windows.Forms.TextBox();
            this.txtBoxPatri = new System.Windows.Forms.TextBox();
            this.txtBoxForn = new System.Windows.Forms.TextBox();
            this.txtBoxGarantia = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(22, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(48, 16);
            this.lblGrupo.TabIndex = 0;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.AutoSize = true;
            this.lblSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGrupo.Location = new System.Drawing.Point(22, 45);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(73, 16);
            this.lblSubGrupo.TabIndex = 1;
            this.lblSubGrupo.Text = "Sub grupo:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(22, 86);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(111, 16);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Número de série:";
            this.lblSerie.Click += new System.EventHandler(this.lblSerie_Click);
            // 
            // lblPatri
            // 
            this.lblPatri.AutoSize = true;
            this.lblPatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatri.Location = new System.Drawing.Point(22, 123);
            this.lblPatri.Name = "lblPatri";
            this.lblPatri.Size = new System.Drawing.Size(75, 16);
            this.lblPatri.TabIndex = 3;
            this.lblPatri.Text = "Patrimonio:";
            // 
            // lblForn
            // 
            this.lblForn.AutoSize = true;
            this.lblForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForn.Location = new System.Drawing.Point(22, 160);
            this.lblForn.Name = "lblForn";
            this.lblForn.Size = new System.Drawing.Size(81, 16);
            this.lblForn.TabIndex = 4;
            this.lblForn.Text = "Fornecedor:";
            // 
            // lblDataAq
            // 
            this.lblDataAq.AutoSize = true;
            this.lblDataAq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAq.Location = new System.Drawing.Point(22, 195);
            this.lblDataAq.Name = "lblDataAq";
            this.lblDataAq.Size = new System.Drawing.Size(121, 16);
            this.lblDataAq.TabIndex = 5;
            this.lblDataAq.Text = "Data de aquisição:";
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(22, 230);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(62, 16);
            this.lblGarantia.TabIndex = 6;
            this.lblGarantia.Text = "Garantia:";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(22, 267);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(97, 16);
            this.lblDep.TabIndex = 7;
            this.lblDep.Text = "Departamento:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(22, 304);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(44, 16);
            this.lblLoc.TabIndex = 8;
            this.lblLoc.Text = "Local:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(22, 340);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(86, 16);
            this.lblObs.TabIndex = 9;
            this.lblObs.Text = "Observação:";
            // 
            // mTxtBoxData
            // 
            this.mTxtBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBoxData.Location = new System.Drawing.Point(150, 195);
            this.mTxtBoxData.Mask = "99/99/9999";
            this.mTxtBoxData.Name = "mTxtBoxData";
            this.mTxtBoxData.Size = new System.Drawing.Size(70, 22);
            this.mTxtBoxData.TabIndex = 10;
            // 
            // txtBoxGrupo
            // 
            this.txtBoxGrupo.Location = new System.Drawing.Point(76, 8);
            this.txtBoxGrupo.Name = "txtBoxGrupo";
            this.txtBoxGrupo.Size = new System.Drawing.Size(163, 20);
            this.txtBoxGrupo.TabIndex = 11;
            // 
            // txtBoxSubGrupo
            // 
            this.txtBoxSubGrupo.Location = new System.Drawing.Point(101, 44);
            this.txtBoxSubGrupo.Name = "txtBoxSubGrupo";
            this.txtBoxSubGrupo.Size = new System.Drawing.Size(138, 20);
            this.txtBoxSubGrupo.TabIndex = 12;
            // 
            // txtBoxNSerie
            // 
            this.txtBoxNSerie.Location = new System.Drawing.Point(139, 85);
            this.txtBoxNSerie.Name = "txtBoxNSerie";
            this.txtBoxNSerie.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNSerie.TabIndex = 13;
            // 
            // txtBoxPatri
            // 
            this.txtBoxPatri.Location = new System.Drawing.Point(103, 122);
            this.txtBoxPatri.Name = "txtBoxPatri";
            this.txtBoxPatri.Size = new System.Drawing.Size(106, 20);
            this.txtBoxPatri.TabIndex = 14;
            // 
            // txtBoxForn
            // 
            this.txtBoxForn.Location = new System.Drawing.Point(109, 159);
            this.txtBoxForn.Name = "txtBoxForn";
            this.txtBoxForn.Size = new System.Drawing.Size(167, 20);
            this.txtBoxForn.TabIndex = 15;
            // 
            // txtBoxGarantia
            // 
            this.txtBoxGarantia.Location = new System.Drawing.Point(90, 229);
            this.txtBoxGarantia.Name = "txtBoxGarantia";
            this.txtBoxGarantia.Size = new System.Drawing.Size(149, 20);
            this.txtBoxGarantia.TabIndex = 16;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(120, 266);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(156, 20);
            this.txtDepartamento.TabIndex = 17;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(72, 303);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(204, 20);
            this.txtLocal.TabIndex = 18;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(27, 368);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(249, 60);
            this.txtObservacao.TabIndex = 19;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(101, 449);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 33);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmCadEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 494);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtBoxGarantia);
            this.Controls.Add(this.txtBoxForn);
            this.Controls.Add(this.txtBoxPatri);
            this.Controls.Add(this.txtBoxNSerie);
            this.Controls.Add(this.txtBoxSubGrupo);
            this.Controls.Add(this.txtBoxGrupo);
            this.Controls.Add(this.mTxtBoxData);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.lblDataAq);
            this.Controls.Add(this.lblForn);
            this.Controls.Add(this.lblPatri);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de equipamento";
            this.Load += new System.EventHandler(this.frmCadEquip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblSubGrupo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblPatri;
        private System.Windows.Forms.Label lblForn;
        private System.Windows.Forms.Label lblDataAq;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.MaskedTextBox mTxtBoxData;
        private System.Windows.Forms.TextBox txtBoxGrupo;
        private System.Windows.Forms.TextBox txtBoxSubGrupo;
        private System.Windows.Forms.TextBox txtBoxNSerie;
        private System.Windows.Forms.TextBox txtBoxPatri;
        private System.Windows.Forms.TextBox txtBoxForn;
        private System.Windows.Forms.TextBox txtBoxGarantia;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnConfirmar;
    }
}