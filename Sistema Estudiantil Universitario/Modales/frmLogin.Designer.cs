namespace Sistema_Estudiantil_Universitario.Modales
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lnkOlvidoClave = new System.Windows.Forms.LinkLabel();
            this.errorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrortxtUsuario = new System.Windows.Forms.Label();
            this.lblErrortxtContraseña = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorClave)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(140, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(156, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "DP18589571";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(140, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(156, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "1234";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(221, 118);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lnkOlvidoClave
            // 
            this.lnkOlvidoClave.AutoSize = true;
            this.lnkOlvidoClave.Location = new System.Drawing.Point(12, 152);
            this.lnkOlvidoClave.Name = "lnkOlvidoClave";
            this.lnkOlvidoClave.Size = new System.Drawing.Size(160, 13);
            this.lnkOlvidoClave.TabIndex = 6;
            this.lnkOlvidoClave.TabStop = true;
            this.lnkOlvidoClave.Text = "¿Olvidaste tu clave de acceso? ";
            this.lnkOlvidoClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOlvidoClave_LinkClicked);
            // 
            // errorUsuario
            // 
            this.errorUsuario.ContainerControl = this;
            // 
            // errorClave
            // 
            this.errorClave.ContainerControl = this;
            // 
            // lblErrortxtUsuario
            // 
            this.lblErrortxtUsuario.AutoSize = true;
            this.lblErrortxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtUsuario.Location = new System.Drawing.Point(143, 56);
            this.lblErrortxtUsuario.Name = "lblErrortxtUsuario";
            this.lblErrortxtUsuario.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtUsuario.TabIndex = 8;
            // 
            // lblErrortxtContraseña
            // 
            this.lblErrortxtContraseña.AutoSize = true;
            this.lblErrortxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtContraseña.Location = new System.Drawing.Point(144, 97);
            this.lblErrortxtContraseña.Name = "lblErrortxtContraseña";
            this.lblErrortxtContraseña.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtContraseña.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(220, 152);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 174);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblErrortxtContraseña);
            this.Controls.Add(this.lblErrortxtUsuario);
            this.Controls.Add(this.lnkOlvidoClave);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autenticación de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lnkOlvidoClave;
        private System.Windows.Forms.ErrorProvider errorUsuario;
        private System.Windows.Forms.ErrorProvider errorClave;
        private System.Windows.Forms.Label lblErrortxtContraseña;
        private System.Windows.Forms.Label lblErrortxtUsuario;
        private System.Windows.Forms.Label lblError;
    }
}