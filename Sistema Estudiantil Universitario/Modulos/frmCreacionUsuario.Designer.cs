namespace Sistema_Estudiantil_Universitario.Modulos
{
    partial class frmCreacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreacionUsuario));
            this.tab = new System.Windows.Forms.TabControl();
            this.listado = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulario = new System.Windows.Forms.TabPage();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblErrortxtUsuario = new System.Windows.Forms.Label();
            this.lblErrortxtContraseña = new System.Windows.Forms.Label();
            this.lblErrortxtConfirmarContraseña = new System.Windows.Forms.Label();
            this.lblErrortxtCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.formulario.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.listado);
            this.tab.Controls.Add(this.formulario);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(462, 484);
            this.tab.TabIndex = 1;
            this.tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Selected);
            // 
            // listado
            // 
            this.listado.Controls.Add(this.splitContainer1);
            this.listado.Location = new System.Drawing.Point(4, 22);
            this.listado.Name = "listado";
            this.listado.Padding = new System.Windows.Forms.Padding(3);
            this.listado.Size = new System.Drawing.Size(454, 458);
            this.listado.TabIndex = 0;
            this.listado.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.txtBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridUsuarios);
            this.splitContainer1.Size = new System.Drawing.Size(448, 452);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(356, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(268, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.AllowUserToOrderColumns = true;
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.CorreoElectronico,
            this.Estatus});
            this.dataGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridUsuarios.RowHeadersVisible = false;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(448, 383);
            this.dataGridUsuarios.StandardTab = true;
            this.dataGridUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.HeaderText = "Correo electrónico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Visible = false;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.grpBox);
            this.formulario.Controls.Add(this.btnGuardar);
            this.formulario.Controls.Add(this.btnCancelar);
            this.formulario.Location = new System.Drawing.Point(4, 22);
            this.formulario.Name = "formulario";
            this.formulario.Padding = new System.Windows.Forms.Padding(3);
            this.formulario.Size = new System.Drawing.Size(454, 458);
            this.formulario.TabIndex = 1;
            this.formulario.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblErrortxtUsuario);
            this.grpBox.Controls.Add(this.lblErrortxtContraseña);
            this.grpBox.Controls.Add(this.lblErrortxtConfirmarContraseña);
            this.grpBox.Controls.Add(this.lblErrortxtCorreoElectronico);
            this.grpBox.Controls.Add(this.txtCorreoElectronico);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.txtConfirmarContraseña);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.txtContraseña);
            this.grpBox.Controls.Add(this.txtUsuario);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Location = new System.Drawing.Point(8, 19);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(403, 191);
            this.grpBox.TabIndex = 2;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Datos del ALumno";
            // 
            // lblErrortxtUsuario
            // 
            this.lblErrortxtUsuario.AutoSize = true;
            this.lblErrortxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtUsuario.Location = new System.Drawing.Point(153, 52);
            this.lblErrortxtUsuario.Name = "lblErrortxtUsuario";
            this.lblErrortxtUsuario.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtUsuario.TabIndex = 4;
            // 
            // lblErrortxtContraseña
            // 
            this.lblErrortxtContraseña.AutoSize = true;
            this.lblErrortxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtContraseña.Location = new System.Drawing.Point(153, 90);
            this.lblErrortxtContraseña.Name = "lblErrortxtContraseña";
            this.lblErrortxtContraseña.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtContraseña.TabIndex = 4;
            // 
            // lblErrortxtConfirmarContraseña
            // 
            this.lblErrortxtConfirmarContraseña.AutoSize = true;
            this.lblErrortxtConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtConfirmarContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtConfirmarContraseña.Location = new System.Drawing.Point(153, 126);
            this.lblErrortxtConfirmarContraseña.Name = "lblErrortxtConfirmarContraseña";
            this.lblErrortxtConfirmarContraseña.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtConfirmarContraseña.TabIndex = 15;
            // 
            // lblErrortxtCorreoElectronico
            // 
            this.lblErrortxtCorreoElectronico.AutoSize = true;
            this.lblErrortxtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtCorreoElectronico.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtCorreoElectronico.Location = new System.Drawing.Point(153, 162);
            this.lblErrortxtCorreoElectronico.Name = "lblErrortxtCorreoElectronico";
            this.lblErrortxtCorreoElectronico.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtCorreoElectronico.TabIndex = 3;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(155, 142);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(213, 20);
            this.txtCorreoElectronico.TabIndex = 14;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            this.txtCorreoElectronico.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correo electrónico";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(155, 106);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(213, 20);
            this.txtConfirmarContraseña.TabIndex = 12;
            this.txtConfirmarContraseña.TextChanged += new System.EventHandler(this.txtConfirmarContraseña_TextChanged);
            this.txtConfirmarContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmarContraseña_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(155, 67);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(213, 20);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(155, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(213, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(336, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCreacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 484);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreacionUsuario";
            this.Text = "Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreacionUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmCreacionUsuario_Load);
            this.tab.ResumeLayout(false);
            this.listado.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.formulario.ResumeLayout(false);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage listado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.TabPage formulario;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblErrortxtUsuario;
        private System.Windows.Forms.Label lblErrortxtContraseña;
        private System.Windows.Forms.Label lblErrortxtConfirmarContraseña;
        private System.Windows.Forms.Label lblErrortxtCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}