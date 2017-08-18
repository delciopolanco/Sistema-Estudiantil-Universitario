namespace Sistema_Estudiantil_Universitario.Modulos
{
    partial class frmHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarios));
            this.tab = new System.Windows.Forms.TabControl();
            this.listado = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridHorarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulario = new System.Windows.Forms.TabPage();
            this.Horario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblErrortxtHorario = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorarios)).BeginInit();
            this.formulario.SuspendLayout();
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
            this.tab.Size = new System.Drawing.Size(403, 348);
            this.tab.TabIndex = 2;
            // 
            // listado
            // 
            this.listado.Controls.Add(this.splitContainer1);
            this.listado.Location = new System.Drawing.Point(4, 22);
            this.listado.Name = "listado";
            this.listado.Padding = new System.Windows.Forms.Padding(3);
            this.listado.Size = new System.Drawing.Size(395, 322);
            this.listado.TabIndex = 0;
            this.listado.Text = "listado";
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridHorarios);
            this.splitContainer1.Size = new System.Drawing.Size(389, 316);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(298, 26);
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
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(210, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridHorarios
            // 
            this.dataGridHorarios.AllowUserToAddRows = false;
            this.dataGridHorarios.AllowUserToDeleteRows = false;
            this.dataGridHorarios.AllowUserToOrderColumns = true;
            this.dataGridHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHorarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Horarios});
            this.dataGridHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHorarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridHorarios.Name = "dataGridHorarios";
            this.dataGridHorarios.ReadOnly = true;
            this.dataGridHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridHorarios.RowHeadersVisible = false;
            this.dataGridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHorarios.Size = new System.Drawing.Size(389, 242);
            this.dataGridHorarios.StandardTab = true;
            this.dataGridHorarios.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Horarios
            // 
            this.Horarios.HeaderText = "Horario";
            this.Horarios.Name = "Horarios";
            this.Horarios.ReadOnly = true;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.lblErrortxtHorario);
            this.formulario.Controls.Add(this.txtHorario);
            this.formulario.Controls.Add(this.Horario);
            this.formulario.Controls.Add(this.btnGuardar);
            this.formulario.Controls.Add(this.btnCancelar);
            this.formulario.Location = new System.Drawing.Point(4, 22);
            this.formulario.Name = "formulario";
            this.formulario.Padding = new System.Windows.Forms.Padding(3);
            this.formulario.Size = new System.Drawing.Size(395, 322);
            this.formulario.TabIndex = 1;
            this.formulario.Text = "formulario";
            this.formulario.UseVisualStyleBackColor = true;
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.Location = new System.Drawing.Point(21, 32);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(41, 13);
            this.Horario.TabIndex = 3;
            this.Horario.Text = "Horario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(207, 71);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(126, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHorario.Location = new System.Drawing.Point(78, 29);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(212, 20);
            this.txtHorario.TabIndex = 5;
            this.txtHorario.TextChanged += new System.EventHandler(this.txtHorario_TextChanged);
            this.txtHorario.Validating += new System.ComponentModel.CancelEventHandler(this.txtHorario_Validating);
            // 
            // lblErrortxtHorario
            // 
            this.lblErrortxtHorario.AutoSize = true;
            this.lblErrortxtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtHorario.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtHorario.Location = new System.Drawing.Point(81, 53);
            this.lblErrortxtHorario.Name = "lblErrortxtHorario";
            this.lblErrortxtHorario.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtHorario.TabIndex = 9;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 348);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHorarios";
            this.Text = "Mantenimiento de Horarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHorarios_FormClosed);
            this.Load += new System.EventHandler(this.frmHorarios_Load);
            this.tab.ResumeLayout(false);
            this.listado.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHorarios)).EndInit();
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.DataGridView dataGridHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horarios;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblErrortxtHorario;
    }
}