namespace Sistema_Estudiantil_Universitario.Modulos
{
    partial class frmProfesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfesion));
            this.tab = new System.Windows.Forms.TabControl();
            this.listado = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridProfesiones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulario = new System.Windows.Forms.TabPage();
            this.txtCodigoProfesion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblErrortxtHorarios = new System.Windows.Forms.Label();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.txtHorarios = new System.Windows.Forms.ListBox();
            this.listBoxHorarios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblErrortxtDuracion = new System.Windows.Forms.Label();
            this.lblErrortxtProfesion = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesiones)).BeginInit();
            this.formulario.SuspendLayout();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
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
            this.tab.Size = new System.Drawing.Size(426, 339);
            this.tab.TabIndex = 2;
            // 
            // listado
            // 
            this.listado.Controls.Add(this.splitContainer1);
            this.listado.Location = new System.Drawing.Point(4, 22);
            this.listado.Name = "listado";
            this.listado.Padding = new System.Windows.Forms.Padding(3);
            this.listado.Size = new System.Drawing.Size(418, 313);
            this.listado.TabIndex = 0;
            this.listado.Text = "Listado de Profesiones";
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridProfesiones);
            this.splitContainer1.Size = new System.Drawing.Size(412, 307);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(326, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridProfesiones
            // 
            this.dataGridProfesiones.AllowUserToAddRows = false;
            this.dataGridProfesiones.AllowUserToDeleteRows = false;
            this.dataGridProfesiones.AllowUserToOrderColumns = true;
            this.dataGridProfesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProfesiones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProfesiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridProfesiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridProfesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Profesion,
            this.Duracion});
            this.dataGridProfesiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProfesiones.Location = new System.Drawing.Point(0, 0);
            this.dataGridProfesiones.Name = "dataGridProfesiones";
            this.dataGridProfesiones.ReadOnly = true;
            this.dataGridProfesiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridProfesiones.RowHeadersVisible = false;
            this.dataGridProfesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProfesiones.Size = new System.Drawing.Size(412, 225);
            this.dataGridProfesiones.StandardTab = true;
            this.dataGridProfesiones.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Profesion
            // 
            this.Profesion.HeaderText = "Profesión";
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.txtCodigoProfesion);
            this.formulario.Controls.Add(this.label3);
            this.formulario.Controls.Add(this.grpBox);
            this.formulario.Controls.Add(this.btnGuardar);
            this.formulario.Controls.Add(this.btnCancelar);
            this.formulario.Location = new System.Drawing.Point(4, 22);
            this.formulario.Name = "formulario";
            this.formulario.Padding = new System.Windows.Forms.Padding(3);
            this.formulario.Size = new System.Drawing.Size(418, 313);
            this.formulario.TabIndex = 1;
            this.formulario.Text = "Agregar Profesión";
            this.formulario.UseVisualStyleBackColor = true;
            // 
            // txtCodigoProfesion
            // 
            this.txtCodigoProfesion.Location = new System.Drawing.Point(286, 9);
            this.txtCodigoProfesion.Name = "txtCodigoProfesion";
            this.txtCodigoProfesion.ReadOnly = true;
            this.txtCodigoProfesion.Size = new System.Drawing.Size(109, 20);
            this.txtCodigoProfesion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblErrortxtHorarios);
            this.grpBox.Controls.Add(this.btnEliminarHorario);
            this.grpBox.Controls.Add(this.btnAgregarHorario);
            this.grpBox.Controls.Add(this.txtHorarios);
            this.grpBox.Controls.Add(this.listBoxHorarios);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.txtDuracion);
            this.grpBox.Controls.Add(this.lblErrortxtDuracion);
            this.grpBox.Controls.Add(this.lblErrortxtProfesion);
            this.grpBox.Controls.Add(this.lblDuracion);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Controls.Add(this.txtProfesion);
            this.grpBox.Controls.Add(this.label10);
            this.grpBox.Location = new System.Drawing.Point(5, 37);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(390, 229);
            this.grpBox.TabIndex = 3;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Datos Estudiantiles";
            // 
            // lblErrortxtHorarios
            // 
            this.lblErrortxtHorarios.AutoSize = true;
            this.lblErrortxtHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtHorarios.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtHorarios.Location = new System.Drawing.Point(160, 209);
            this.lblErrortxtHorarios.Name = "lblErrortxtHorarios";
            this.lblErrortxtHorarios.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtHorarios.TabIndex = 16;
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(249, 162);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(26, 23);
            this.btnEliminarHorario.TabIndex = 15;
            this.btnEliminarHorario.Text = "<";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(249, 133);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(26, 23);
            this.btnAgregarHorario.TabIndex = 14;
            this.btnAgregarHorario.Text = ">";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // txtHorarios
            // 
            this.txtHorarios.FormattingEnabled = true;
            this.txtHorarios.Location = new System.Drawing.Point(281, 111);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(88, 95);
            this.txtHorarios.TabIndex = 13;
            this.txtHorarios.SelectedIndexChanged += new System.EventHandler(this.txtHorarios_SelectedIndexChanged);
            this.txtHorarios.Validating += new System.ComponentModel.CancelEventHandler(this.txtHorarios_Validating);
            // 
            // listBoxHorarios
            // 
            this.listBoxHorarios.FormattingEnabled = true;
            this.listBoxHorarios.Location = new System.Drawing.Point(155, 111);
            this.listBoxHorarios.Name = "listBoxHorarios";
            this.listBoxHorarios.Size = new System.Drawing.Size(88, 95);
            this.listBoxHorarios.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Horarios";
            // 
            // txtDuracion
            // 
            this.txtDuracion.DecimalPlaces = 1;
            this.txtDuracion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtDuracion.Location = new System.Drawing.Point(155, 69);
            this.txtDuracion.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(71, 20);
            this.txtDuracion.TabIndex = 10;
            this.txtDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDuracion.ValueChanged += new System.EventHandler(this.txtDuracion_ValueChanged);
            this.txtDuracion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuracion_Validating);
            // 
            // lblErrortxtDuracion
            // 
            this.lblErrortxtDuracion.AutoSize = true;
            this.lblErrortxtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtDuracion.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtDuracion.Location = new System.Drawing.Point(153, 92);
            this.lblErrortxtDuracion.Name = "lblErrortxtDuracion";
            this.lblErrortxtDuracion.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtDuracion.TabIndex = 9;
            // 
            // lblErrortxtProfesion
            // 
            this.lblErrortxtProfesion.AutoSize = true;
            this.lblErrortxtProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtProfesion.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtProfesion.Location = new System.Drawing.Point(153, 53);
            this.lblErrortxtProfesion.Name = "lblErrortxtProfesion";
            this.lblErrortxtProfesion.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtProfesion.TabIndex = 8;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(226, 72);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(34, 13);
            this.lblDuracion.TabIndex = 7;
            this.lblDuracion.Text = "1 año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duración";
            // 
            // txtProfesion
            // 
            this.txtProfesion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfesion.Location = new System.Drawing.Point(155, 30);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(212, 20);
            this.txtProfesion.TabIndex = 4;
            this.txtProfesion.TextChanged += new System.EventHandler(this.txtProfesion_TextChanged);
            this.txtProfesion.Leave += new System.EventHandler(this.txtProfesion_Leave);
            this.txtProfesion.Validating += new System.ComponentModel.CancelEventHandler(this.txtProfesion_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Profesión";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(320, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmProfesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 339);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfesion";
            this.Text = "Mantenimiento de Profesiones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProfesion_FormClosed);
            this.Load += new System.EventHandler(this.frmProfesion_Load);
            this.tab.ResumeLayout(false);
            this.listado.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesiones)).EndInit();
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage listado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage formulario;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridProfesiones;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrortxtDuracion;
        private System.Windows.Forms.Label lblErrortxtProfesion;
        private System.Windows.Forms.TextBox txtCodigoProfesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.NumericUpDown txtDuracion;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.ListBox txtHorarios;
        private System.Windows.Forms.ListBox listBoxHorarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrortxtHorarios;
    }
}