using b_Multiplex;
using b_Multiplex.Aspectos;
using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using Castle.DynamicProxy;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormMultiplex
{
    public partial class FormMultiplex : Form
    {
        public Multiplex cineMultiplex;
        FormCartelera formCartelera;
        FormReservas formReservas;

        public List<Espectador> sesionEspectador;

        List<string> l_reset = new List<string>();

        public FormMultiplex()
        {
            InitializeComponent();
            formCartelera = new FormCartelera(this);
            formReservas = new FormReservas(this);

        }

        private void FormMultiplex_Load(object sender, EventArgs e)
        {
            try
            {
                cineMultiplex = new Multiplex("Multiplex-SA", "Calle 1");
                cineMultiplex.L_peliculasActivas.Add(new Pelicula("init", new TimeSpan(1, 2, 2), 0, "init"));

                //Cargar clientes
                CargarDatosCliente();

                //Cargar peliculas
                CargarDatosPeliculas();
                formCartelera.ActualizarCartelera();

                //Cargar Funciones
                CargarDatosFunciones();

                //Cargar taquilleros
                CargarDatosTaquilleros();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el Formulario: \n" + ex);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || txtTelefono.Text == "")
                    MessageBox.Show("Debes rellenar todos los datos");
                else
                {
                    string Nombre = txtNombre.Text;
                    long Id;
                    byte Edad;
                    long Telefono;

                    if (long.TryParse(txtId.Text, out Id))
                    {
                        if (byte.TryParse(txtEdad.Text, out Edad))
                        {
                            if (long.TryParse(txtTelefono.Text, out Telefono))
                            {
                                Normal normal = new Normal(Id, Nombre, Edad, Telefono);
                                Multiplex.l_espectadores.Add(normal);

                                dgvClientes.DataSource = null;
                                dgvClientes.DataSource = Multiplex.l_espectadores;
                                dgvClientes.Refresh();

                                LimpiarDatosClientes();

                                MessageBox.Show("Se ha añadido un cliente");
                            }
                            else MessageBox.Show("El Telefono de be ser numerico de 10 digitos");
                        }
                        else MessageBox.Show("La edad debe ser numerico");
                    }
                    else MessageBox.Show("El ID de be ser numerico de 8 digitos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buttonAgregarCliente: " + ex);
            }
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                //Crea Objeto tipo explorador de archivos
                OpenFileDialog explorador = new OpenFileDialog();

                //Abre el explorador
                explorador.ShowDialog();

                //Obtiene el nombre del archivo y Setea la ruta en textBoxRuta
                cineMultiplex.RutaArchivoClientes = txtRuta.Text = explorador.FileName;

                CargarDatosCliente();

                LimpiarDatosClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buttonCargarDatos: " + ex);
            }
        }

        public void LimpiarDatosClientes()
        {
            try
            {
                txtId.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al LimpiarDatosClientes: " + ex);
            }

        }

        public void CargarDatosCliente()
        {
            try
            {
                //Instancio un generador de conexiones a Proxies
                var gen_proxies = new ProxyGenerator();

                //Crear el proxy dinamico ==> contra/conectandolo a la interface
                IArchivos? proxy_Archivos = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(IArchivos), //Interface
                    cineMultiplex, //La clase que tiene implementada la interface
                    new InterceptorCombo()) //Proxy que intercepta las peticiones
                    as IArchivos;

                proxy_Archivos.LeerDBCliente();

                dgvClientes.DataSource = null;

                dgvClientes.Rows.Clear();
                dgvClientes.Columns.Clear();

                // Configurar las columnas del DataGridView
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = Multiplex.l_espectadores;

                DataGridViewTextBoxColumn columnaId = new DataGridViewTextBoxColumn();
                columnaId.DataPropertyName = "Id";
                columnaId.HeaderText = "ID";
                columnaId.Width = 80;
                dgvClientes.Columns.Add(columnaId);

                DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
                columnaNombre.DataPropertyName = "Nombre";
                columnaNombre.HeaderText = "Nombre";
                columnaNombre.Width = 120;
                dgvClientes.Columns.Add(columnaNombre);

                DataGridViewTextBoxColumn columnaEdad = new DataGridViewTextBoxColumn();
                columnaEdad.DataPropertyName = "Edad";
                columnaEdad.HeaderText = "Edad";
                columnaEdad.Width = 50;
                dgvClientes.Columns.Add(columnaEdad);

                DataGridViewTextBoxColumn columnaTelefono = new DataGridViewTextBoxColumn();
                columnaTelefono.DataPropertyName = "Telefono";
                columnaTelefono.HeaderText = "Telefono";
                columnaTelefono.Width = 100;
                dgvClientes.Columns.Add(columnaTelefono);

                DataGridViewTextBoxColumn columnaPuntos = new DataGridViewTextBoxColumn();
                columnaPuntos.DataPropertyName = "Puntos";
                columnaPuntos.HeaderText = "Puntos";
                columnaPuntos.Width = 60;
                dgvClientes.Columns.Add(columnaPuntos);

                DataGridViewTextBoxColumn columnaCategoria = new DataGridViewTextBoxColumn();
                columnaCategoria.DataPropertyName = "Categoria";
                columnaCategoria.HeaderText = "Categoria";
                columnaCategoria.Width = 100;
                dgvClientes.Columns.Add(columnaCategoria);

                dgvClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CargarDatosCliente: " + ex);
            }
        }

        public void CargarDatosPeliculas()
        {
            try
            {
                //Instancio un generador de conexiones a Proxies
                var gen_proxies = new ProxyGenerator();

                //Crear el proxy dinamico ==> contra/conectandolo a la interface
                IArchivos? proxy_Archivos = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(IArchivos), //Interface
                    cineMultiplex, //La clase que tiene implementada la interface
                    new InterceptorCombo()) //Proxy que intercepta las peticiones
                    as IArchivos;

                proxy_Archivos.LeerDBPeliculas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CargarDatosPeliculas: " + ex);
            }
        }

        private void buttonVerCartelera_Click(object sender, EventArgs e)
        {
            try
            {
                formCartelera.Visible = true;
                Enabled = false;
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buttonVerCartelera: " + ex);
            }
        }

        private void buttonReservarFuncion_Click(object sender, EventArgs e)
        {
            try
            {
                formReservas.cargarEspectador();
                formReservas.cargarCBFunciones();

                formReservas.Visible = true;
                tabControl.TabPages[1].Enabled = false;
                gbLogin.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buttonReservarFuncion: " + ex);
            }
        }

        public void CargarDatosFunciones()
        {
            try
            {
                //Instancio un generador de conexiones a Proxies
                var gen_proxies = new ProxyGenerator();

                //Crear el proxy dinamico ==> contra/conectandolo a la interface
                IArchivos? proxy_Archivos = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(IArchivos), //Interface
                    cineMultiplex, //La clase que tiene implementada la interface
                    new InterceptorCombo()) //Proxy que intercepta las peticiones
                    as IArchivos;

                cineMultiplex.L_funciones.Clear();
                proxy_Archivos.LeerDBFunciones();

                dgvFunciones.DataSource = null;

                dgvFunciones.Rows.Clear();
                dgvFunciones.Columns.Clear();

                // Configurar las columnas del DataGridView
                dgvFunciones.AutoGenerateColumns = false;
                dgvFunciones.DataSource = cineMultiplex.L_funciones;

                DataGridViewTextBoxColumn columnaCodigo = new DataGridViewTextBoxColumn();
                columnaCodigo.DataPropertyName = "Codigo";
                columnaCodigo.HeaderText = "Codigo";
                columnaCodigo.Width = 60;
                dgvFunciones.Columns.Add(columnaCodigo);

                DataGridViewTextBoxColumn columnaHora = new DataGridViewTextBoxColumn();
                columnaHora.DataPropertyName = "Hora";
                columnaHora.HeaderText = "Fecha";
                columnaHora.Width = 150;
                dgvFunciones.Columns.Add(columnaHora);

                DataGridViewTextBoxColumn columnaSalaId = new DataGridViewTextBoxColumn();
                columnaSalaId.DataPropertyName = "SalaId";
                columnaSalaId.HeaderText = "Sala";
                columnaSalaId.Width = 40;
                dgvFunciones.Columns.Add(columnaSalaId);

                DataGridViewTextBoxColumn columnaPelicula = new DataGridViewTextBoxColumn();
                columnaPelicula.DataPropertyName = "PeliculaNombre";
                columnaPelicula.HeaderText = "Película";
                columnaPelicula.Width = 200;
                dgvFunciones.Columns.Add(columnaPelicula);

                dgvFunciones.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CargarDatosFunciones: " + ex);
            }
        }

        public void CargarDatosTaquilleros()
        {
            try
            {
                //Instancio un generador de conexiones a Proxies
                var gen_proxies = new ProxyGenerator();

                //Crear el proxy dinamico ==> contra/conectandolo a la interface
                IArchivos? proxy_Archivos = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(IArchivos), //Interface
                    cineMultiplex, //La clase que tiene implementada la interface
                    new InterceptorCombo()) //Proxy que intercepta las peticiones
                    as IArchivos;

                proxy_Archivos.LeerDBTaquilleros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CargarDatosTaquilleros: " + ex);
            }

        }

        private void buttonInciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (txtIdInicio.Text == "") {
                    MessageBox.Show("Debes dar un id");
                }
                else
                {
                    long valorTXT = long.Parse(txtIdInicio.Text);

                    var IdValido = Multiplex.l_espectadores.Where(persona => persona.Id == valorTXT).ToList();


                    if (IdValido.Count() == 0)
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    else
                    {
                        MessageBox.Show($"Usuario encontrado\n Bienvenido!! {IdValido[0].Nombre}");
                        
                        sesionEspectador = IdValido;

                        cargarDatosInicio();

                        buttonInciarSesion.Enabled = false;
                        buttonSalir.Enabled = true;
                        buttonSalir.Visible = true;
                        buttonReservarFuncion.Enabled = true;
                        txtIdInicio.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buttonInciarSesion: " + ex);
            }
        }

        public void cargarDatosInicio()
        {
            try
            {
                lblNombreInicio.Text = sesionEspectador[0].Nombre;
                lblEdadInicio.Text = sesionEspectador[0].Edad.ToString();
                lblTelefonoInicio.Text = sesionEspectador[0].Telefono.ToString();
                lblCategoriaInicio.Text = sesionEspectador[0].Categoria;
                lblPuntosInicio.Text = sesionEspectador[0].Puntos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buttonSalir: " + ex);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            try
            {
                buttonSalir.Enabled = false;
                buttonSalir.Visible = false;
                buttonInciarSesion.Enabled = true;
                buttonReservarFuncion.Enabled = false;
                txtIdInicio.Text = "";
                txtIdInicio.Enabled = true;

                lblNombreInicio.Text = "";
                lblEdadInicio.Text = "";
                lblTelefonoInicio.Text = "";
                lblCategoriaInicio.Text = "";
                lblPuntosInicio.Text = "";

                sesionEspectador.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buttonSalir: " + ex);
            }            
        }
    }
}
