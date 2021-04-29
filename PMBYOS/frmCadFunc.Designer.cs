
namespace PMBYOS
{
    partial class frmCadFunc
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
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.txtboxDep = new System.Windows.Forms.TextBox();
            this.txtboxCargo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblEncarregado = new System.Windows.Forms.Label();
            this.txtBoxEncarregado = new System.Windows.Forms.TextBox();
            this.mTxtBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtboxNome
            // 
            this.txtboxNome.Location = new System.Drawing.Point(68, 42);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(236, 20);
            this.txtboxNome.TabIndex = 0;
            this.txtboxNome.TextChanged += new System.EventHandler(this.txtboxNome_TextChanged);
            // 
            // txtboxDep
            // 
            this.txtboxDep.Location = new System.Drawing.Point(122, 87);
            this.txtboxDep.Name = "txtboxDep";
            this.txtboxDep.Size = new System.Drawing.Size(182, 20);
            this.txtboxDep.TabIndex = 1;
            this.txtboxDep.TextChanged += new System.EventHandler(this.txtboxDep_TextChanged);
            // 
            // txtboxCargo
            // 
            this.txtboxCargo.Location = new System.Drawing.Point(97, 134);
            this.txtboxCargo.Name = "txtboxCargo";
            this.txtboxCargo.Size = new System.Drawing.Size(218, 20);
            this.txtboxCargo.TabIndex = 2;
            this.txtboxCargo.TextChanged += new System.EventHandler(this.txtboxCargo_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(4, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(4, 88);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(104, 16);
            this.lblDep.TabIndex = 4;
            this.lblDep.Text = "Departamento:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(21, 135);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 16);
            this.lblCargo.TabIndex = 5;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(23, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(12, 232);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(71, 16);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Telefone:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(97, 181);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(218, 20);
            this.txtboxEmail.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(122, 318);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 40);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblEncarregado
            // 
            this.lblEncarregado.AutoSize = true;
            this.lblEncarregado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncarregado.Location = new System.Drawing.Point(4, 278);
            this.lblEncarregado.Name = "lblEncarregado";
            this.lblEncarregado.Size = new System.Drawing.Size(96, 16);
            this.lblEncarregado.TabIndex = 13;
            this.lblEncarregado.Text = "Encarregado:";
            // 
            // txtBoxEncarregado
            // 
            this.txtBoxEncarregado.Location = new System.Drawing.Point(100, 277);
            this.txtBoxEncarregado.Name = "txtBoxEncarregado";
            this.txtBoxEncarregado.Size = new System.Drawing.Size(215, 20);
            this.txtBoxEncarregado.TabIndex = 14;
            // 
            // mTxtBoxTel
            // 
            this.mTxtBoxTel.Location = new System.Drawing.Point(100, 232);
            this.mTxtBoxTel.Mask = "(99)9999-9999";
            this.mTxtBoxTel.Name = "mTxtBoxTel";
            this.mTxtBoxTel.Size = new System.Drawing.Size(85, 20);
            this.mTxtBoxTel.TabIndex = 15;
            this.mTxtBoxTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTextBoxTel_MaskInputRejected);
            // 
            // frmCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 379);
            this.Controls.Add(this.mTxtBoxTel);
            this.Controls.Add(this.txtBoxEncarregado);
            this.Controls.Add(this.lblEncarregado);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtboxCargo);
            this.Controls.Add(this.txtboxDep);
            this.Controls.Add(this.txtboxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionário";
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.TextBox txtboxDep;
        private System.Windows.Forms.TextBox txtboxCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblEncarregado;
        private System.Windows.Forms.TextBox txtBoxEncarregado;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTel;
    }
}