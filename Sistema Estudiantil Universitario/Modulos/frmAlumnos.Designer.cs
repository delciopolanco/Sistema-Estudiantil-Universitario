namespace Sistema_Estudiantil_Universitario.Modulos
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.tab = new System.Windows.Forms.TabControl();
            this.listado = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.formulario = new System.Windows.Forms.TabPage();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorTxtHorario = new System.Windows.Forms.Label();
            this.lblErrortxtIdProfesion = new System.Windows.Forms.Label();
            this.lblErrortxtDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblErrortxtTelefono = new System.Windows.Forms.Label();
            this.lblErrortxtFechaNacimiento = new System.Windows.Forms.Label();
            this.lblErrortxtSexo = new System.Windows.Forms.Label();
            this.lblErrortxtIdentificacion = new System.Windows.Forms.Label();
            this.lblErrortxtApellidos = new System.Windows.Forms.Label();
            this.lblErrortxtNombres = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.btnElegirProfesion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.rdlMasculino = new System.Windows.Forms.RadioButton();
            this.rdlFemenino = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProfesion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tab.Size = new System.Drawing.Size(846, 351);
            this.tab.TabIndex = 0;
            // 
            // listado
            // 
            this.listado.Controls.Add(this.splitContainer1);
            this.listado.Location = new System.Drawing.Point(4, 22);
            this.listado.Name = "listado";
            this.listado.Padding = new System.Windows.Forms.Padding(3);
            this.listado.Size = new System.Drawing.Size(838, 325);
            this.listado.TabIndex = 0;
            this.listado.Text = "Listado de Alumnos";
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
            this.splitContainer1.Size = new System.Drawing.Size(832, 319);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(748, 23);
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
            this.txtBuscar.Size = new System.Drawing.Size(636, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(660, 24);
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
            this.Nombre,
            this.Apellidos,
            this.Identificacion,
            this.Matricula,
            this.Profesion});
            this.dataGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridUsuarios.RowHeadersVisible = false;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(832, 251);
            this.dataGridUsuarios.StandardTab = true;
            this.dataGridUsuarios.TabIndex = 1;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.grpBox);
            this.formulario.Controls.Add(this.btnGuardar);
            this.formulario.Controls.Add(this.btnCancelar);
            this.formulario.Location = new System.Drawing.Point(4, 22);
            this.formulario.Name = "formulario";
            this.formulario.Padding = new System.Windows.Forms.Padding(3);
            this.formulario.Size = new System.Drawing.Size(838, 325);
            this.formulario.TabIndex = 1;
            this.formulario.Text = "Agregar Alumno";
            this.formulario.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.txtHorario);
            this.grpBox.Controls.Add(this.label6);
            this.grpBox.Controls.Add(this.lblErrorTxtHorario);
            this.grpBox.Controls.Add(this.lblErrortxtIdProfesion);
            this.grpBox.Controls.Add(this.lblErrortxtDireccion);
            this.grpBox.Controls.Add(this.txtTelefono);
            this.grpBox.Controls.Add(this.label13);
            this.grpBox.Controls.Add(this.lblErrortxtTelefono);
            this.grpBox.Controls.Add(this.lblErrortxtFechaNacimiento);
            this.grpBox.Controls.Add(this.lblErrortxtSexo);
            this.grpBox.Controls.Add(this.lblErrortxtIdentificacion);
            this.grpBox.Controls.Add(this.lblErrortxtApellidos);
            this.grpBox.Controls.Add(this.lblErrortxtNombres);
            this.grpBox.Controls.Add(this.txtIdentificacion);
            this.grpBox.Controls.Add(this.btnElegirProfesion);
            this.grpBox.Controls.Add(this.lblIdentificacion);
            this.grpBox.Controls.Add(this.rdlMasculino);
            this.grpBox.Controls.Add(this.rdlFemenino);
            this.grpBox.Controls.Add(this.txtDireccion);
            this.grpBox.Controls.Add(this.txtFechaNacimiento);
            this.grpBox.Controls.Add(this.label5);
            this.grpBox.Controls.Add(this.txtApellidos);
            this.grpBox.Controls.Add(this.txtNombres);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.txtIdProfesion);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Controls.Add(this.label10);
            this.grpBox.Location = new System.Drawing.Point(8, 23);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(822, 244);
            this.grpBox.TabIndex = 2;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Datos del ALumno";
            // 
            // txtHorario
            // 
            this.txtHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHorario.FormattingEnabled = true;
            this.txtHorario.Location = new System.Drawing.Point(549, 183);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(213, 21);
            this.txtHorario.TabIndex = 32;
            this.txtHorario.SelectedValueChanged += new System.EventHandler(this.txtHorario_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Horario";
            // 
            // lblErrorTxtHorario
            // 
            this.lblErrorTxtHorario.AutoSize = true;
            this.lblErrorTxtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTxtHorario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTxtHorario.Location = new System.Drawing.Point(548, 207);
            this.lblErrorTxtHorario.Name = "lblErrorTxtHorario";
            this.lblErrorTxtHorario.Size = new System.Drawing.Size(0, 12);
            this.lblErrorTxtHorario.TabIndex = 30;
            // 
            // lblErrortxtIdProfesion
            // 
            this.lblErrortxtIdProfesion.AutoSize = true;
            this.lblErrortxtIdProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtIdProfesion.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtIdProfesion.Location = new System.Drawing.Point(548, 167);
            this.lblErrortxtIdProfesion.Name = "lblErrortxtIdProfesion";
            this.lblErrortxtIdProfesion.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtIdProfesion.TabIndex = 29;
            // 
            // lblErrortxtDireccion
            // 
            this.lblErrortxtDireccion.AutoSize = true;
            this.lblErrortxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtDireccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtDireccion.Location = new System.Drawing.Point(548, 130);
            this.lblErrortxtDireccion.Name = "lblErrortxtDireccion";
            this.lblErrortxtDireccion.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtDireccion.TabIndex = 28;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(549, 31);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 20);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefono_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Teléfono";
            // 
            // lblErrortxtTelefono
            // 
            this.lblErrortxtTelefono.AutoSize = true;
            this.lblErrortxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtTelefono.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtTelefono.Location = new System.Drawing.Point(548, 53);
            this.lblErrortxtTelefono.Name = "lblErrortxtTelefono";
            this.lblErrortxtTelefono.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtTelefono.TabIndex = 25;
            // 
            // lblErrortxtFechaNacimiento
            // 
            this.lblErrortxtFechaNacimiento.AutoSize = true;
            this.lblErrortxtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtFechaNacimiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtFechaNacimiento.Location = new System.Drawing.Point(155, 208);
            this.lblErrortxtFechaNacimiento.Name = "lblErrortxtFechaNacimiento";
            this.lblErrortxtFechaNacimiento.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtFechaNacimiento.TabIndex = 24;
            // 
            // lblErrortxtSexo
            // 
            this.lblErrortxtSexo.AutoSize = true;
            this.lblErrortxtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtSexo.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtSexo.Location = new System.Drawing.Point(155, 168);
            this.lblErrortxtSexo.Name = "lblErrortxtSexo";
            this.lblErrortxtSexo.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtSexo.TabIndex = 23;
            // 
            // lblErrortxtIdentificacion
            // 
            this.lblErrortxtIdentificacion.AutoSize = true;
            this.lblErrortxtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtIdentificacion.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtIdentificacion.Location = new System.Drawing.Point(155, 130);
            this.lblErrortxtIdentificacion.Name = "lblErrortxtIdentificacion";
            this.lblErrortxtIdentificacion.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtIdentificacion.TabIndex = 22;
            // 
            // lblErrortxtApellidos
            // 
            this.lblErrortxtApellidos.AutoSize = true;
            this.lblErrortxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtApellidos.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtApellidos.Location = new System.Drawing.Point(154, 91);
            this.lblErrortxtApellidos.Name = "lblErrortxtApellidos";
            this.lblErrortxtApellidos.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtApellidos.TabIndex = 21;
            // 
            // lblErrortxtNombres
            // 
            this.lblErrortxtNombres.AutoSize = true;
            this.lblErrortxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrortxtNombres.ForeColor = System.Drawing.Color.Red;
            this.lblErrortxtNombres.Location = new System.Drawing.Point(154, 52);
            this.lblErrortxtNombres.Name = "lblErrortxtNombres";
            this.lblErrortxtNombres.Size = new System.Drawing.Size(0, 12);
            this.lblErrortxtNombres.TabIndex = 20;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(155, 109);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(213, 20);
            this.txtIdentificacion.TabIndex = 15;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            this.txtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdentificacion_Validating);
            // 
            // btnElegirProfesion
            // 
            this.btnElegirProfesion.ImageIndex = 0;
            this.btnElegirProfesion.ImageList = this.imageList1;
            this.btnElegirProfesion.Location = new System.Drawing.Point(772, 144);
            this.btnElegirProfesion.Name = "btnElegirProfesion";
            this.btnElegirProfesion.Size = new System.Drawing.Size(31, 21);
            this.btnElegirProfesion.TabIndex = 18;
            this.btnElegirProfesion.UseVisualStyleBackColor = true;
            this.btnElegirProfesion.Click += new System.EventHandler(this.btnElegirProfesion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_gnome-searchtool_22031.png");
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(28, 109);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 14;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // rdlMasculino
            // 
            this.rdlMasculino.AutoSize = true;
            this.rdlMasculino.Location = new System.Drawing.Point(247, 148);
            this.rdlMasculino.Name = "rdlMasculino";
            this.rdlMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdlMasculino.TabIndex = 13;
            this.rdlMasculino.Text = "Masculino";
            this.rdlMasculino.UseVisualStyleBackColor = true;
            // 
            // rdlFemenino
            // 
            this.rdlFemenino.AutoSize = true;
            this.rdlFemenino.Checked = true;
            this.rdlFemenino.Location = new System.Drawing.Point(155, 148);
            this.rdlFemenino.Name = "rdlFemenino";
            this.rdlFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdlFemenino.TabIndex = 12;
            this.rdlFemenino.TabStop = true;
            this.rdlFemenino.Text = "Femenino";
            this.rdlFemenino.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(549, 70);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(213, 58);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.Text = "";
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDireccion_Validating);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(155, 185);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(165, 20);
            this.txtFechaNacimiento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(155, 70);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(213, 20);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            this.txtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidos_Validating);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(155, 31);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(213, 20);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombres_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // txtIdProfesion
            // 
            this.txtIdProfesion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdProfesion.Enabled = false;
            this.txtIdProfesion.Location = new System.Drawing.Point(549, 145);
            this.txtIdProfesion.Name = "txtIdProfesion";
            this.txtIdProfesion.Size = new System.Drawing.Size(213, 20);
            this.txtIdProfesion.TabIndex = 4;
            this.txtIdProfesion.TextChanged += new System.EventHandler(this.txtIdProfesion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Profesión";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(753, 286);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(672, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificación";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Profesion
            // 
            this.Profesion.HeaderText = "Profesión";
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 351);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlumnos";
            this.Text = "Mantenimiento de Alumnos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAlumnos_FormClosed);
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
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
        private System.Windows.Forms.TabPage formulario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdlMasculino;
        private System.Windows.Forms.RadioButton rdlFemenino;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnElegirProfesion;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblErrortxtTelefono;
        private System.Windows.Forms.Label lblErrortxtFechaNacimiento;
        private System.Windows.Forms.Label lblErrortxtSexo;
        private System.Windows.Forms.Label lblErrortxtIdentificacion;
        private System.Windows.Forms.Label lblErrortxtApellidos;
        private System.Windows.Forms.Label lblErrortxtNombres;
        private System.Windows.Forms.Label lblErrortxtIdProfesion;
        private System.Windows.Forms.Label lblErrortxtDireccion;
        private System.Windows.Forms.ComboBox txtHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErrorTxtHorario;
        public System.Windows.Forms.TextBox txtIdProfesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
    }
}