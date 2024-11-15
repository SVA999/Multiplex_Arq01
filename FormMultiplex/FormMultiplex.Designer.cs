namespace FormMultiplex
{
    partial class FormMultiplex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultiplex));
            tabControl = new TabControl();
            tabHome = new TabPage();
            gbFunciones = new GroupBox();
            dgvFunciones = new DataGridView();
            buttonReservarFuncion = new Button();
            gbCartelera = new GroupBox();
            buttonVerCartelera = new Button();
            gbLogin = new GroupBox();
            lblPuntosInicio = new Label();
            lblPuntosInicio1 = new Label();
            lblCategoriaInicio = new Label();
            lblCategoriaInicio1 = new Label();
            lblTelefonoInicio = new Label();
            lblEdadInicio = new Label();
            lblNombreInicio = new Label();
            lblTelefonoInicio1 = new Label();
            lblEdadInicio1 = new Label();
            lblNombreInicio1 = new Label();
            buttonSalir = new Button();
            buttonInciarSesion = new Button();
            txtIdInicio = new TextBox();
            lblID2 = new Label();
            tabClientes = new TabPage();
            dgvClientes = new DataGridView();
            gbCargarClientes = new GroupBox();
            txtRuta = new TextBox();
            buttonCargarDatos = new Button();
            gbAgregarCliente = new GroupBox();
            buttonAgregar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtId = new TextBox();
            lblId1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            multiplexBindingSource = new BindingSource(components);
            tabControl.SuspendLayout();
            tabHome.SuspendLayout();
            gbFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            gbCartelera.SuspendLayout();
            gbLogin.SuspendLayout();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbCargarClientes.SuspendLayout();
            gbAgregarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)multiplexBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabHome);
            tabControl.Controls.Add(tabClientes);
            tabControl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(880, 547);
            tabControl.TabIndex = 1;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(gbFunciones);
            tabHome.Controls.Add(gbCartelera);
            tabHome.Controls.Add(gbLogin);
            tabHome.Location = new Point(4, 29);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(872, 514);
            tabHome.TabIndex = 1;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // gbFunciones
            // 
            gbFunciones.Controls.Add(dgvFunciones);
            gbFunciones.Controls.Add(buttonReservarFuncion);
            gbFunciones.Location = new Point(308, 99);
            gbFunciones.Name = "gbFunciones";
            gbFunciones.Size = new Size(543, 401);
            gbFunciones.TabIndex = 2;
            gbFunciones.TabStop = false;
            gbFunciones.Text = "Funciones Hoy";
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToOrderColumns = true;
            dgvFunciones.AllowUserToResizeColumns = false;
            dgvFunciones.BackgroundColor = Color.White;
            dgvFunciones.BorderStyle = BorderStyle.None;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Location = new Point(6, 24);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFunciones.Size = new Size(531, 312);
            dgvFunciones.TabIndex = 4;
            // 
            // buttonReservarFuncion
            // 
            buttonReservarFuncion.Enabled = false;
            buttonReservarFuncion.Location = new Point(6, 348);
            buttonReservarFuncion.Name = "buttonReservarFuncion";
            buttonReservarFuncion.Size = new Size(531, 40);
            buttonReservarFuncion.TabIndex = 0;
            buttonReservarFuncion.Text = "Reservar Funcion";
            buttonReservarFuncion.UseVisualStyleBackColor = true;
            buttonReservarFuncion.Click += buttonReservarFuncion_Click;
            // 
            // gbCartelera
            // 
            gbCartelera.Controls.Add(buttonVerCartelera);
            gbCartelera.Location = new Point(308, 13);
            gbCartelera.Name = "gbCartelera";
            gbCartelera.Size = new Size(543, 80);
            gbCartelera.TabIndex = 1;
            gbCartelera.TabStop = false;
            gbCartelera.Text = "Cartelera";
            // 
            // buttonVerCartelera
            // 
            buttonVerCartelera.Location = new Point(6, 24);
            buttonVerCartelera.Name = "buttonVerCartelera";
            buttonVerCartelera.Size = new Size(531, 40);
            buttonVerCartelera.TabIndex = 0;
            buttonVerCartelera.Text = "Ver peliculas presentadas";
            buttonVerCartelera.UseVisualStyleBackColor = true;
            buttonVerCartelera.Click += buttonVerCartelera_Click;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(lblPuntosInicio);
            gbLogin.Controls.Add(lblPuntosInicio1);
            gbLogin.Controls.Add(lblCategoriaInicio);
            gbLogin.Controls.Add(lblCategoriaInicio1);
            gbLogin.Controls.Add(lblTelefonoInicio);
            gbLogin.Controls.Add(lblEdadInicio);
            gbLogin.Controls.Add(lblNombreInicio);
            gbLogin.Controls.Add(lblTelefonoInicio1);
            gbLogin.Controls.Add(lblEdadInicio1);
            gbLogin.Controls.Add(lblNombreInicio1);
            gbLogin.Controls.Add(buttonSalir);
            gbLogin.Controls.Add(buttonInciarSesion);
            gbLogin.Controls.Add(txtIdInicio);
            gbLogin.Controls.Add(lblID2);
            gbLogin.Location = new Point(10, 13);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(277, 487);
            gbLogin.TabIndex = 0;
            gbLogin.TabStop = false;
            gbLogin.Text = "Inicio de Sesion";
            // 
            // lblPuntosInicio
            // 
            lblPuntosInicio.AutoSize = true;
            lblPuntosInicio.Location = new Point(15, 332);
            lblPuntosInicio.Name = "lblPuntosInicio";
            lblPuntosInicio.Size = new Size(27, 20);
            lblPuntosInicio.TabIndex = 16;
            lblPuntosInicio.Text = "---";
            // 
            // lblPuntosInicio1
            // 
            lblPuntosInicio1.AutoSize = true;
            lblPuntosInicio1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPuntosInicio1.Location = new Point(6, 312);
            lblPuntosInicio1.Name = "lblPuntosInicio1";
            lblPuntosInicio1.Size = new Size(58, 20);
            lblPuntosInicio1.TabIndex = 15;
            lblPuntosInicio1.Text = "Puntos";
            // 
            // lblCategoriaInicio
            // 
            lblCategoriaInicio.AutoSize = true;
            lblCategoriaInicio.Location = new Point(15, 292);
            lblCategoriaInicio.Name = "lblCategoriaInicio";
            lblCategoriaInicio.Size = new Size(27, 20);
            lblCategoriaInicio.TabIndex = 14;
            lblCategoriaInicio.Text = "---";
            // 
            // lblCategoriaInicio1
            // 
            lblCategoriaInicio1.AutoSize = true;
            lblCategoriaInicio1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCategoriaInicio1.Location = new Point(6, 272);
            lblCategoriaInicio1.Name = "lblCategoriaInicio1";
            lblCategoriaInicio1.Size = new Size(76, 20);
            lblCategoriaInicio1.TabIndex = 13;
            lblCategoriaInicio1.Text = "Categoría";
            // 
            // lblTelefonoInicio
            // 
            lblTelefonoInicio.AutoSize = true;
            lblTelefonoInicio.Location = new Point(13, 249);
            lblTelefonoInicio.Name = "lblTelefonoInicio";
            lblTelefonoInicio.Size = new Size(27, 20);
            lblTelefonoInicio.TabIndex = 12;
            lblTelefonoInicio.Text = "---";
            // 
            // lblEdadInicio
            // 
            lblEdadInicio.AutoSize = true;
            lblEdadInicio.Location = new Point(13, 206);
            lblEdadInicio.Name = "lblEdadInicio";
            lblEdadInicio.Size = new Size(27, 20);
            lblEdadInicio.TabIndex = 12;
            lblEdadInicio.Text = "---";
            // 
            // lblNombreInicio
            // 
            lblNombreInicio.AutoSize = true;
            lblNombreInicio.Location = new Point(15, 162);
            lblNombreInicio.Name = "lblNombreInicio";
            lblNombreInicio.Size = new Size(27, 20);
            lblNombreInicio.TabIndex = 12;
            lblNombreInicio.Text = "---";
            // 
            // lblTelefonoInicio1
            // 
            lblTelefonoInicio1.AutoSize = true;
            lblTelefonoInicio1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTelefonoInicio1.Location = new Point(6, 229);
            lblTelefonoInicio1.Name = "lblTelefonoInicio1";
            lblTelefonoInicio1.Size = new Size(70, 20);
            lblTelefonoInicio1.TabIndex = 11;
            lblTelefonoInicio1.Text = "Teléfono";
            // 
            // lblEdadInicio1
            // 
            lblEdadInicio1.AutoSize = true;
            lblEdadInicio1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblEdadInicio1.Location = new Point(8, 186);
            lblEdadInicio1.Name = "lblEdadInicio1";
            lblEdadInicio1.Size = new Size(43, 20);
            lblEdadInicio1.TabIndex = 9;
            lblEdadInicio1.Text = "Edad";
            // 
            // lblNombreInicio1
            // 
            lblNombreInicio1.AutoSize = true;
            lblNombreInicio1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombreInicio1.Location = new Point(7, 142);
            lblNombreInicio1.Name = "lblNombreInicio1";
            lblNombreInicio1.Size = new Size(67, 20);
            lblNombreInicio1.TabIndex = 6;
            lblNombreInicio1.Text = "Nombre";
            // 
            // buttonSalir
            // 
            buttonSalir.Enabled = false;
            buttonSalir.Location = new Point(149, 86);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(114, 36);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Visible = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonInciarSesion
            // 
            buttonInciarSesion.Location = new Point(15, 86);
            buttonInciarSesion.Name = "buttonInciarSesion";
            buttonInciarSesion.Size = new Size(128, 36);
            buttonInciarSesion.TabIndex = 5;
            buttonInciarSesion.Text = "Inciar Sesión";
            buttonInciarSesion.UseVisualStyleBackColor = true;
            buttonInciarSesion.Click += buttonInciarSesion_Click;
            // 
            // txtIdInicio
            // 
            txtIdInicio.Location = new Point(15, 56);
            txtIdInicio.Name = "txtIdInicio";
            txtIdInicio.Size = new Size(248, 27);
            txtIdInicio.TabIndex = 4;
            // 
            // lblID2
            // 
            lblID2.AutoSize = true;
            lblID2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID2.Location = new Point(15, 36);
            lblID2.Name = "lblID2";
            lblID2.Size = new Size(25, 20);
            lblID2.TabIndex = 0;
            lblID2.Text = "ID";
            // 
            // tabClientes
            // 
            tabClientes.BackColor = Color.Transparent;
            tabClientes.Controls.Add(dgvClientes);
            tabClientes.Controls.Add(gbCargarClientes);
            tabClientes.Controls.Add(gbAgregarCliente);
            tabClientes.Location = new Point(4, 29);
            tabClientes.Margin = new Padding(0);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(872, 514);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 45, 66);
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(141, 153, 174);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EditMode = DataGridViewEditMode.EditOnF2;
            dgvClientes.Location = new Point(289, 13);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(576, 497);
            dgvClientes.TabIndex = 3;
            // 
            // gbCargarClientes
            // 
            gbCargarClientes.Controls.Add(txtRuta);
            gbCargarClientes.Controls.Add(buttonCargarDatos);
            gbCargarClientes.Location = new Point(13, 381);
            gbCargarClientes.Name = "gbCargarClientes";
            gbCargarClientes.Size = new Size(260, 129);
            gbCargarClientes.TabIndex = 2;
            gbCargarClientes.TabStop = false;
            gbCargarClientes.Text = "Cargar Clientes";
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(7, 39);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(247, 27);
            txtRuta.TabIndex = 10;
            // 
            // buttonCargarDatos
            // 
            buttonCargarDatos.Location = new Point(41, 70);
            buttonCargarDatos.Name = "buttonCargarDatos";
            buttonCargarDatos.Size = new Size(167, 42);
            buttonCargarDatos.TabIndex = 9;
            buttonCargarDatos.Text = "Cargar Datos";
            buttonCargarDatos.UseVisualStyleBackColor = true;
            buttonCargarDatos.Click += buttonCargarDatos_Click;
            // 
            // gbAgregarCliente
            // 
            gbAgregarCliente.Controls.Add(buttonAgregar);
            gbAgregarCliente.Controls.Add(txtTelefono);
            gbAgregarCliente.Controls.Add(lblTelefono);
            gbAgregarCliente.Controls.Add(txtEdad);
            gbAgregarCliente.Controls.Add(lblEdad);
            gbAgregarCliente.Controls.Add(txtId);
            gbAgregarCliente.Controls.Add(lblId1);
            gbAgregarCliente.Controls.Add(txtNombre);
            gbAgregarCliente.Controls.Add(lblNombre);
            gbAgregarCliente.Location = new Point(13, 13);
            gbAgregarCliente.Name = "gbAgregarCliente";
            gbAgregarCliente.Size = new Size(260, 340);
            gbAgregarCliente.TabIndex = 0;
            gbAgregarCliente.TabStop = false;
            gbAgregarCliente.Text = "Agregar Cliente";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Transparent;
            buttonAgregar.FlatStyle = FlatStyle.System;
            buttonAgregar.Location = new Point(41, 273);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(167, 42);
            buttonAgregar.TabIndex = 8;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(6, 221);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(248, 27);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(7, 198);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(6, 164);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(248, 27);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(7, 141);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 53);
            txtId.Name = "txtId";
            txtId.Size = new Size(248, 27);
            txtId.TabIndex = 3;
            // 
            // lblId1
            // 
            lblId1.AutoSize = true;
            lblId1.Location = new Point(7, 30);
            lblId1.Name = "lblId1";
            lblId1.Size = new Size(22, 20);
            lblId1.TabIndex = 2;
            lblId1.Text = "Id";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // multiplexBindingSource
            // 
            multiplexBindingSource.DataSource = typeof(b_Multiplex.Clases.Multiplex);
            // 
            // FormMultiplex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMultiplex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiplex";
            Load += FormMultiplex_Load;
            tabControl.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            gbFunciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            gbCartelera.ResumeLayout(false);
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbCargarClientes.ResumeLayout(false);
            gbCargarClientes.PerformLayout();
            gbAgregarCliente.ResumeLayout(false);
            gbAgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)multiplexBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal TabControl tabControl;
        private TabPage tabClientes;
        private TabPage tabHome;
        private GroupBox gbAgregarCliente;
        private GroupBox gbCargarClientes;
        private Label lblNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtId;
        private Label lblId1;
        private TextBox txtNombre;
        private Button buttonCargarDatos;
        private Button buttonAgregar;
        private DataGridView dgvClientes;
        private BindingSource multiplexBindingSource;
        private TextBox txtRuta;
        private GroupBox gbCartelera;
        internal GroupBox gbLogin;
        private Button buttonVerCartelera;
        private GroupBox gbFunciones;
        internal DataGridView dgvFunciones;
        private Button buttonReservarFuncion;
        private Label lblID2;
        private Label lblTelefonoInicio;
        private Label lblEdadInicio;
        private Label lblNombreInicio;
        private Label lblTelefonoInicio1;
        private Label lblEdadInicio1;
        private Label lblNombreInicio1;
        private Button buttonInciarSesion;
        private TextBox txtIdInicio;
        private Button buttonSalir;
        private Label lblCategoriaInicio;
        private Label lblCategoriaInicio1;
        private Label lblPuntosInicio;
        private Label lblPuntosInicio1;
    }
}
