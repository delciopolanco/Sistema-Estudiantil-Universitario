namespace Sistema_Estudiantil_Universitario.Modales
{
    partial class frmCambioClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioClave));
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblErrortxtContraseña = new System.Windows.Forms.Label();
            this.lblErrortxtConfirmarContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña nueva";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(141, 20);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(184, 20);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(141, 59);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(184, 20);
            this.txtConfirmarContraseña.TabIndex = 4;
            this.txtConfirmarContraseña.TextChanged += new System.EventHandler(this.txtConfirmarContraseña_TextChanged);
            this.txtConfirmarContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmarContraseña_Validating);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(248, 103);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblErrortxtContraseña
            // 
            this.lblErrortxtContraseña.AutoSize = true;
            this.lblErrortxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtContraseña.Location = new System.Drawing.Point(140, 41);
            this.lblErrortxtContraseña.Name = "lblErrortxtContraseña";
            this.lblErrortxtContraseña.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtContraseña.TabIndex = 10;
            // 
            // lblErrortxtConfirmarContraseña
            // 
            this.lblErrortxtConfirmarContraseña.AutoSize = true;
            this.lblErrortxtConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtConfirmarContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtConfirmarContraseña.Location = new System.Drawing.Point(142, 80);
            this.lblErrortxtConfirmarContraseña.Name = "lblErrortxtConfirmarContraseña";
            this.lblErrortxtConfirmarContraseña.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtConfirmarContraseña.TabIndex = 11;
            // 
            // frmCambioClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 136);
            this.Controls.Add(this.lblErrortxtConfirmarContraseña);
            this.Controls.Add(this.lblErrortxtContraseña);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambioClave";
            this.Text = "Cambiar clave acceso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCambioClave_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblErrortxtContraseña;
        private System.Windows.Forms.Label lblErrortxtConfirmarContraseña;
    }
}