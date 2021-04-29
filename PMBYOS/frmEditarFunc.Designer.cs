
namespace PMBYOS
{
    partial class frmEditarFunc
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEncarregado = new System.Windows.Forms.Label();
            this.mTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxDep = new System.Windows.Forms.TextBox();
            this.txtBoxCargo = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxEncarregado = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(12, 80);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(97, 16);
            this.lblDep.TabIndex = 1;
            this.lblDep.Text = "Departamento:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(12, 130);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(48, 16);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(11, 233);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(65, 16);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Telefone:";
            // 
            // lblEncarregado
            // 
            this.lblEncarregado.AutoSize = true;
            this.lblEncarregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncarregado.Location = new System.Drawing.Point(11, 283);
            this.lblEncarregado.Name = "lblEncarregado";
            this.lblEncarregado.Size = new System.Drawing.Size(90, 16);
            this.lblEncarregado.TabIndex = 5;
            this.lblEncarregado.Text = "Encarregado:";
            // 
            // mTextBoxTel
            // 
            this.mTextBoxTel.Location = new System.Drawing.Point(82, 232);
            this.mTextBoxTel.Mask = "(99)9999-9999";
            this.mTextBoxTel.Name = "mTextBoxTel";
            this.mTextBoxTel.Size = new System.Drawing.Size(77, 20);
            this.mTextBoxTel.TabIndex = 6;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(66, 28);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(229, 20);
            this.txtBoxNome.TabIndex = 7;
            // 
            // txtBoxDep
            // 
            this.txtBoxDep.Location = new System.Drawing.Point(115, 79);
            this.txtBoxDep.Name = "txtBoxDep";
            this.txtBoxDep.Size = new System.Drawing.Size(180, 20);
            this.txtBoxDep.TabIndex = 8;
            // 
            // txtBoxCargo
            // 
            this.txtBoxCargo.Location = new System.Drawing.Point(66, 129);
            this.txtBoxCargo.Name = "txtBoxCargo";
            this.txtBoxCargo.Size = new System.Drawing.Size(206, 20);
            this.txtBoxCargo.TabIndex = 9;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(66, 185);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(206, 20);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // txtBoxEncarregado
            // 
            this.txtBoxEncarregado.Location = new System.Drawing.Point(107, 282);
            this.txtBoxEncarregado.Name = "txtBoxEncarregado";
            this.txtBoxEncarregado.Size = new System.Drawing.Size(165, 20);
            this.txtBoxEncarregado.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(97, 329);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 34);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmEditarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 375);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtBoxEncarregado);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxCargo);
            this.Controls.Add(this.txtBoxDep);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.mTextBoxTel);
            this.Controls.Add(this.lblEncarregado);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNome);
            this.Name = "frmEditarFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEncarregado;
        private System.Windows.Forms.MaskedTextBox mTextBoxTel;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxDep;
        private System.Windows.Forms.TextBox txtBoxCargo;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxEncarregado;
        private System.Windows.Forms.Button btnConfirmar;
    }
}