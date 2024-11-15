using b_Multiplex.Aspectos;
using b_Multiplex.Clases;
using b_Multiplex.Interfaces;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormMultiplex
{
    public partial class FormReservas : Form
    {
        FormMultiplex formsMultiplexOriginal;

        int valorTotal = 0;
        float descuento = 0f;
        bool siVip;
        string posicion;
        string s_cbFuncion;
        Funcion funcion;
        byte tipoCombo;


        public FormReservas(FormMultiplex formMultiplex)
        {
            InitializeComponent();
            formsMultiplexOriginal = formMultiplex;

        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                Visible = false;
                formsMultiplexOriginal.Enabled = true;
                formsMultiplexOriginal.Visible = true;
                formsMultiplexOriginal.Enabled = true;
                resetForm();
                formsMultiplexOriginal.Focus();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CerrarCartelera: " + ex);
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instancio un generador de conexiones a Proxies
                var gen_proxies = new ProxyGenerator();

                //Crear el proxy dinamico ==> contra/conectandolo a la interface
                ICombo? proxy_Combo = gen_proxies.CreateInterfaceProxyWithTarget(
                    typeof(ICombo), //Interface
                    formsMultiplexOriginal.sesionEspectador[0], //La clase que tiene implementada la interface
                    new InterceptorCombo()) //Proxy que intercepta las peticiones
                    as ICombo;


                posicion = txtPosicionSilla.Text;
                s_cbFuncion = cbFunciones.Text;
                funcion = formsMultiplexOriginal.cineMultiplex.L_funciones.FirstOrDefault(f => f.Codigo == s_cbFuncion);
                if (funcion != null)
                {
                    CalcularTotal();

                    if(rbSi.Checked == true)
                    {
                        if (rbAutomatico.Checked == true)
                        {
                            MessageBox.Show(formsMultiplexOriginal.cineMultiplex.L_taquilleros[0].VenderBoleta(
                                funcion, formsMultiplexOriginal.sesionEspectador[0], siVip));
                            MessageBox.Show(proxy_Combo.ComprarCombo(tipoCombo));

                            formsMultiplexOriginal.sesionEspectador[0] = Multiplex.l_espectadores.FirstOrDefault(e => e.Id == formsMultiplexOriginal.sesionEspectador[0].Id);
                            formsMultiplexOriginal.cargarDatosInicio();

                            resetForm();
                        }
                        if (rbElegir.Checked == true)
                        {
                            MessageBox.Show(formsMultiplexOriginal.cineMultiplex.L_taquilleros[0].VenderBoleta(
                                funcion, formsMultiplexOriginal.sesionEspectador[0], posicion, siVip));
                            MessageBox.Show(proxy_Combo.ComprarCombo(tipoCombo));

                            formsMultiplexOriginal.sesionEspectador[0] = Multiplex.l_espectadores.FirstOrDefault(e => e.Id == formsMultiplexOriginal.sesionEspectador[0].Id);
                            formsMultiplexOriginal.cargarDatosInicio();

                            resetForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show(formsMultiplexOriginal.cineMultiplex.L_taquilleros[0].VenderBoleta(
                                funcion, formsMultiplexOriginal.sesionEspectador[0], siVip));    

                        formsMultiplexOriginal.sesionEspectador[0] = Multiplex.l_espectadores.FirstOrDefault(e => e.Id == formsMultiplexOriginal.sesionEspectador[0].Id);
                        formsMultiplexOriginal.cargarDatosInicio();

                        resetForm();
                    }


                }
                else MessageBox.Show("Codigo de fucion invalido: ");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buttonComprar: " + ex);
            }
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            cargarEspectador();
            cargarCBFunciones();
            validacionCombo();
        }

        public void resetForm()
        {
            try
            {
                Visible = false;
                formsMultiplexOriginal.Enabled = true;
                formsMultiplexOriginal.Visible = true;
                formsMultiplexOriginal.Enabled = true;
                formsMultiplexOriginal.tabControl.TabPages[1].Enabled = true;
                formsMultiplexOriginal.gbLogin.Enabled = true;
                rdNo.Checked = true;
                rbAutomatico.Checked = false;
                rbElegir.Checked = false;
                rbVip.Checked = false;
                rbGeneral.Checked = false;
                gbPosicion.Visible = false;
                buttonComprar.BackColor = Color.White;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargarCBFunciones: " + ex);
            }
        }


        public void validacionCombo()
        {
            try
            {
                if (formsMultiplexOriginal.sesionEspectador[0] is Normal)
                {
                    rbCombo1.Visible = true;
                    rbCombo2.Visible = true;
                    rbCombo3.Visible = true;
                    rbCombo4.Visible = false;
                    rbCombo5.Visible = false;
                } else if (formsMultiplexOriginal.sesionEspectador[0] is Platino)
                {
                    rbCombo1.Visible = true;
                    rbCombo2.Visible = true;
                    rbCombo3.Visible = true;
                    rbCombo4.Visible = true;
                    rbCombo5.Visible = false;
                } else if (formsMultiplexOriginal.sesionEspectador[0] is Oro)
                {
                    rbCombo1.Visible = true;
                    rbCombo2.Visible = true;
                    rbCombo3.Visible = true;
                    rbCombo4.Visible = true;
                    rbCombo5.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargarCBFunciones: " + ex);
            }
        }
       

        public void cargarCBFunciones()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = formsMultiplexOriginal.cineMultiplex.L_funciones;
                cbFunciones.DataSource = bindingSource;
                cbFunciones.DisplayMember = "Codigo";
                cbFunciones.ValueMember = "Codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargarCBFunciones: " + ex);
            }
        }

        public void cargarEspectador()
        {
            try
            {
                lblNombre.Text = formsMultiplexOriginal.sesionEspectador[0].Nombre;
                lblId.Text = formsMultiplexOriginal.sesionEspectador[0].Id.ToString();
                lblCategoria.Text = formsMultiplexOriginal.sesionEspectador[0].Categoria;
                lblDescuento.Text = (1-formsMultiplexOriginal.sesionEspectador[0].Descuento).ToString("F");
                lblPuntos.Text = formsMultiplexOriginal.sesionEspectador[0].Puntos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargarEspectador: " + ex);
            }
        }

        public void CalcularTotal()
        {
            try
            {
                valorTotal = 0;

                if (rbGeneral.Checked == true)
                {
                    siVip = false;
                    valorTotal += Multiplex.valorSillaGeneral;
                }
                if (rbVip.Checked == true)
                {
                    siVip = true;
                    valorTotal += Multiplex.valorSillaVip;
                }

                if (rbCombo1.Checked == true)
                {
                    tipoCombo = 1;
                    valorTotal += Multiplex.precioCombo1;
                }
                else if (rbCombo2.Checked == true)
                {
                    tipoCombo = 2;
                    valorTotal += Multiplex.precioCombo2;
                }
                else if (rbCombo3.Checked == true)
                {
                    tipoCombo = 3;
                    valorTotal += Multiplex.precioCombo3;
                }
                else if (rbCombo4.Checked == true)
                {
                    tipoCombo = 4;
                    valorTotal += Multiplex.precioCombo4;
                }
                else if (rbCombo5.Checked == true)
                {
                    tipoCombo = 5;
                    valorTotal += Multiplex.precioCombo5;
                }
                else
                {
                    tipoCombo = 0;
                }

                valorTotal = (int)(valorTotal * formsMultiplexOriginal.sesionEspectador[0].Descuento);

                lblValor.Text = valorTotal.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CalcularTotal: " + ex);
            }

        }

        private void DeseleccionarRB()
        {
            gbCombos.Controls.OfType<RadioButton>()
                       .ToList()
                       .ForEach(radioButton => radioButton.Checked = false);
        }

        private void rbElegir_CheckedChanged(object sender, EventArgs e)
        {
            lblPosicionSilla.Visible = true;
            txtPosicionSilla.Visible = true;
            buttonComprar.Enabled = true;
            buttonComprar.BackColor = Color.FromArgb(239, 35, 60);
        }

        private void rbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            lblPosicionSilla.Visible = false;
            txtPosicionSilla.Visible = false;
            buttonComprar.Enabled = true;
            buttonComprar.BackColor = Color.FromArgb(239, 35, 60);
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            validacionCombo();
            rbCombo1.Checked = true;
            gbCombos.Visible =true;
            gbCombos.Enabled = true;

        }

        private void rdNo_CheckedChanged(object sender, EventArgs e)
        {
            validacionCombo();
            DeseleccionarRB();
            CalcularTotal();
            gbCombos.Visible = false;
            gbCombos.Enabled = false;
        }

        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            gbPosicion.Visible = true;
            CalcularTotal();
        }

        private void rbVip_CheckedChanged(object sender, EventArgs e)
        {
            gbPosicion.Visible = true;
            CalcularTotal();
        }

        private void gbCombos_Enter(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void rbCombo1_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void rbCombo2_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void rbCombo3_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void rbCombo4_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void rbCombo5_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
