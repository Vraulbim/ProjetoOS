
namespace PMBYOS
{
    partial class frmCadForn
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
            this.txtBoxRazao = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.lblrazao = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblinscricao = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtBoxInscricao = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.txtBoxBairro = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.mTxtBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxCel = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtBoxRazao
            // 
            this.txtBoxRazao.Location = new System.Drawing.Point(113, 18);
            this.txtBoxRazao.Name = "txtBoxRazao";
            this.txtBoxRazao.Size = new System.Drawing.Size(257, 20);
            this.txtBoxRazao.TabIndex = 0;
            this.txtBoxRazao.TextChanged += new System.EventHandler(this.txtBoxRazao_TextChanged);
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(93, 66);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(277, 20);
            this.txtBoxEndereco.TabIndex = 1;
            // 
            // lblrazao
            // 
            this.lblrazao.AutoSize = true;
            this.lblrazao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrazao.Location = new System.Drawing.Point(12, 19);
            this.lblrazao.Name = "lblrazao";
            this.lblrazao.Size = new System.Drawing.Size(95, 16);
            this.lblrazao.TabIndex = 3;
            this.lblrazao.Text = "Razão social:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 67);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(38, 16);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Rua:";
            this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(12, 111);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(46, 16);
            this.lblCnpj.TabIndex = 5;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblinscricao
            // 
            this.lblinscricao.AutoSize = true;
            this.lblinscricao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinscricao.Location = new System.Drawing.Point(12, 157);
            this.lblinscricao.Name = "lblinscricao";
            this.lblinscricao.Size = new System.Drawing.Size(74, 16);
            this.lblinscricao.TabIndex = 6;
            this.lblinscricao.Text = "Inscrição:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(12, 205);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(71, 16);
            this.lbTel.TabIndex = 7;
            this.lbTel.Text = "Telefone:";
            // 
            // txtBoxInscricao
            // 
            this.txtBoxInscricao.Location = new System.Drawing.Point(92, 156);
            this.txtBoxInscricao.Name = "txtBoxInscricao";
            this.txtBoxInscricao.Size = new System.Drawing.Size(132, 20);
            this.txtBoxInscricao.TabIndex = 8;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(72, 253);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(277, 20);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 254);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(12, 301);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(58, 16);
            this.lblCel.TabIndex = 13;
            this.lblCel.Text = "Celular:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(384, 67);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(30, 16);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Nº:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(523, 67);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 16);
            this.lblBairro.TabIndex = 15;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(420, 66);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(83, 20);
            this.txtBoxNum.TabIndex = 16;
            // 
            // txtBoxBairro
            // 
            this.txtBoxBairro.Location = new System.Drawing.Point(580, 66);
            this.txtBoxBairro.Name = "txtBoxBairro";
            this.txtBoxBairro.Size = new System.Drawing.Size(194, 20);
            this.txtBoxBairro.TabIndex = 17;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(314, 349);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(133, 35);
            this.btnconfirmar.TabIndex = 18;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // mTxtBoxCNPJ
            // 
            this.mTxtBoxCNPJ.Location = new System.Drawing.Point(72, 110);
            this.mTxtBoxCNPJ.Mask = "99999999/9999-99";
            this.mTxtBoxCNPJ.Name = "mTxtBoxCNPJ";
            this.mTxtBoxCNPJ.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxCNPJ.TabIndex = 19;
            this.mTxtBoxCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mTxtBoxCel
            // 
            this.mTxtBoxCel.Location = new System.Drawing.Point(76, 300);
            this.mTxtBoxCel.Mask = "(99)99999-9999";
            this.mTxtBoxCel.Name = "mTxtBoxCel";
            this.mTxtBoxCel.Size = new System.Drawing.Size(96, 20);
            this.mTxtBoxCel.TabIndex = 20;
            // 
            // mTxtBoxTel
            // 
            this.mTxtBoxTel.Location = new System.Drawing.Point(89, 204);
            this.mTxtBoxTel.Mask = "(99)9999-9999";
            this.mTxtBoxTel.Name = "mTxtBoxTel";
            this.mTxtBoxTel.Size = new System.Drawing.Size(83, 20);
            this.mTxtBoxTel.TabIndex = 21;
            // 
            // frmCadForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 402);
            this.Controls.Add(this.mTxtBoxTel);
            this.Controls.Add(this.mTxtBoxCel);
            this.Controls.Add(this.mTxtBoxCNPJ);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtBoxBairro);
            this.Controls.Add(this.txtBoxNum);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxInscricao);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lblinscricao);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblrazao);
            this.Controls.Add(this.txtBoxEndereco);
            this.Controls.Add(this.txtBoxRazao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fornecedor";
            this.Load += new System.EventHandler(this.frmCadForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRazao;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.Label lblrazao;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblinscricao;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox txtBoxInscricao;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.TextBox txtBoxBairro;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.MaskedTextBox mTxtBoxCNPJ;
        private System.Windows.Forms.MaskedTextBox mTxtBoxCel;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTel;
    }
}