using b_Multiplex;
using b_Multiplex.Clases;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormMultiplex
{
    public partial class FormMultiplex : Form
    {
        public FormMultiplex()
        {
            InitializeComponent();
        }

        private void FormMultiplex_Load(object sender, EventArgs e)
        {
            Multiplex multiplex = new Multiplex("Multiplex-SA", "Calle 1");


        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtNombre.Text == ""  || txtEdad.Text == "" || txtTelefono.Text == "")
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

    }
}
