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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultiplex));
            tabControl = new TabControl();
            tabHome = new TabPage();
            tabClientes = new TabPage();
            dgvClientes = new DataGridView();
            gbCargarClientes = new GroupBox();
            buttonCargarDatos = new Button();
            gbAgregarCliente = new GroupBox();
            buttonAgregar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tabPage1 = new TabPage();
            multiplexBindingSource = new BindingSource(components);
            tabControl.SuspendLayout();
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
            tabControl.Controls.Add(tabPage1);
            tabControl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(880, 547);
            tabControl.TabIndex = 1;
            // 
            // tabHome
            // 
            tabHome.Location = new Point(4, 26);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(872, 517);
            tabHome.TabIndex = 1;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(dgvClientes);
            tabClientes.Controls.Add(gbCargarClientes);
            tabClientes.Controls.Add(gbAgregarCliente);
            tabClientes.Location = new Point(4, 26);
            tabClientes.Margin = new Padding(0);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(872, 517);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(289, 13);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(576, 497);
            dgvClientes.TabIndex = 3;
            // 
            // gbCargarClientes
            // 
            gbCargarClientes.Controls.Add(buttonCargarDatos);
            gbCargarClientes.Location = new Point(13, 381);
            gbCargarClientes.Name = "gbCargarClientes";
            gbCargarClientes.Size = new Size(260, 129);
            gbCargarClientes.TabIndex = 2;
            gbCargarClientes.TabStop = false;
            gbCargarClientes.Text = "Cargar Clientes";
            // 
            // buttonCargarDatos
            // 
            buttonCargarDatos.Location = new Point(41, 53);
            buttonCargarDatos.Name = "buttonCargarDatos";
            buttonCargarDatos.Size = new Size(167, 42);
            buttonCargarDatos.TabIndex = 9;
            buttonCargarDatos.Text = "Cargar Datos";
            buttonCargarDatos.UseVisualStyleBackColor = true;
            // 
            // gbAgregarCliente
            // 
            gbAgregarCliente.Controls.Add(buttonAgregar);
            gbAgregarCliente.Controls.Add(txtTelefono);
            gbAgregarCliente.Controls.Add(lblTelefono);
            gbAgregarCliente.Controls.Add(txtEdad);
            gbAgregarCliente.Controls.Add(lblEdad);
            gbAgregarCliente.Controls.Add(txtId);
            gbAgregarCliente.Controls.Add(lblId);
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
            buttonAgregar.Location = new Point(41, 273);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(167, 42);
            buttonAgregar.TabIndex = 8;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(6, 221);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(248, 25);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(7, 198);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 17);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(6, 164);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(248, 25);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(7, 141);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(38, 17);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 53);
            txtId.Name = "txtId";
            txtId.Size = new Size(248, 25);
            txtId.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(7, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 17);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 517);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // multiplexBindingSource
            // 
            multiplexBindingSource.DataSource = typeof(b_Multiplex.Clases.Multiplex);
            // 
            // FormMultiplex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMultiplex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiplex";
            Load += FormMultiplex_Load;
            tabControl.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbCargarClientes.ResumeLayout(false);
            gbAgregarCliente.ResumeLayout(false);
            gbAgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)multiplexBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabClientes;
        private TabPage tabHome;
        private GroupBox gbAgregarCliente;
        private TabPage tabPage1;
        private GroupBox gbCargarClientes;
        private Label lblNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtNombre;
        private Button buttonCargarDatos;
        private Button buttonAgregar;
        private DataGridView dgvClientes;
        private BindingSource multiplexBindingSource;
    }
}
