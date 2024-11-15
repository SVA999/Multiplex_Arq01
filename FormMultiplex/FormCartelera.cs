using b_Multiplex.Clases;
using b_Multiplex.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace FormMultiplex
{
    public partial class FormCartelera : Form
    {
        List<string> l_reset = new List<string>();

        FormMultiplex formMultiplexOrigen;

        byte grupoPelicula = 1;
        Image imagenPelicula;

        //Atributo Publisher CambioCartelera
        internal Publisher_CambioCartelera publisher_cambiocartelera;

        internal void EventHandler() { }

        const byte puntosPlatino = Multiplex.puntosPlatino;
        const byte puntosOro = Multiplex.puntosOro;


        public FormCartelera(FormMultiplex formMultiplex)
        {
            InitializeComponent();
            formMultiplexOrigen = formMultiplex;

        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                Visible = false;
                formMultiplexOrigen.Enabled = true;
                formMultiplexOrigen.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al CerrarCartelera: " + ex);
            }
        }

        private void AsignarImagenes(int id)
        {
            try
            {
                if (id >= 1 || id <= formMultiplexOrigen.cineMultiplex.L_peliculas.Count)
                {
                    switch (id)
                    {
                        case 1:
                            imagenPelicula = Properties.Resources.Deadpool3;
                            break;
                        case 2:
                            imagenPelicula = Properties.Resources.LaSustancia;
                            break;
                        case 3:
                            imagenPelicula = Properties.Resources.Moana2;
                            break;
                        case 4:
                            imagenPelicula = Properties.Resources.Venom3;
                            break;
                        case 5:
                            imagenPelicula = Properties.Resources.RedOne;
                            break;
                        case 6:
                            imagenPelicula = Properties.Resources.HomeAlone;
                            break;
                        case 7:
                            imagenPelicula = Properties.Resources.ElGrinch;
                            break;
                        case 8:
                            imagenPelicula = Properties.Resources.UnaNavidadPrendida;
                            break;
                        default:
                            throw new Exception("Error en Id de imagen: ");       
                    }
                }
                else throw new Exception("El id de la pelicula no esta en el rango");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al AsignarImagenes: " + ex);
            }
        }


        public void ActualizarCartelera()
        {
            try
            {
                //EVENTO COMPRA
                publisher_cambiocartelera = new Publisher_CambioCartelera();

                //Suscribirme al evento
                publisher_cambiocartelera.evt_cambioCartelera += EventHandler;


                if (grupoPelicula == 1)
                {
                    //Llamada evento CabioCartelera
                    MessageBox.Show(publisher_cambiocartelera.CabioCartelera());

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Clear();

                    //Pelicula 1
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[0].Id);
                    imgPelicula1.Image = imagenPelicula;
                    gbPelicula1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[0].Nombre;
                    lblGenero1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[0].Genero;

                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[0].EdadMinima == 0)
                    {
                        lblEdad1.Text = "Para todo el Público";
                    }
                    else lblEdad1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[0].EdadMinima.ToString();
                    lblDuracion1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[0].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[0]);

                    //Pelicula 2
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[1].Id);
                    imgPelicula2.Image = imagenPelicula;
                    gbPelicula2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[1].Nombre;
                    lblGenero2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[1].Genero;
                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[1].EdadMinima == 0)
                    {
                        lblEdad2.Text = "Para todo el Público";
                    }
                    else lblEdad2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[1].EdadMinima.ToString();
                    lblDuracion2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[1].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[1]);

                    //Pelicula 3
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[2].Id);
                    imgPelicula3.Image = imagenPelicula;
                    gbPelicula3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[2].Nombre;
                    lblGenero3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[2].Genero;
                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[2].EdadMinima == 0)
                    {
                        lblEdad3.Text = "Para todo el Público";
                    }
                    else lblEdad3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[2].EdadMinima.ToString();
                    lblDuracion3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[2].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[2]);

                    //Pelicula 4
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[3].Id);
                    imgPelicula4.Image = imagenPelicula;
                    gbPelicula4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[3].Nombre;
                    lblGenero4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[3].Genero;
                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[3].EdadMinima == 0)
                    {
                        lblEdad4.Text = "Para todo el Público";
                    }
                    else lblEdad4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[3].EdadMinima.ToString();
                    lblDuracion4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[3].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[3]);

                    grupoPelicula++;

                }
                else if (grupoPelicula == 2)
                {
                    //Llamada evento CabioCartelera
                    MessageBox.Show(publisher_cambiocartelera.CabioCartelera());

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Clear();

                    //Pelicula 1
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[4].Id);
                    imgPelicula1.Image = imagenPelicula;
                    gbPelicula1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[4].Nombre;
                    lblGenero1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[4].Genero;

                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[4].EdadMinima == 0)
                    {
                        lblEdad1.Text = "Para todo el Público";
                    }
                    else lblEdad1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[4].EdadMinima.ToString();
                    lblDuracion1.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[4].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[4]);

                    //Pelicula 2
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[5].Id);
                    imgPelicula2.Image = imagenPelicula;
                    gbPelicula2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[5].Nombre;
                    lblGenero2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[5].Genero;
                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[5].EdadMinima == 0)
                    {
                        lblEdad2.Text = "Para todo el Público";
                    }
                    else lblEdad2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[5].EdadMinima.ToString();
                    lblDuracion2.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[5].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[5]);

                    //Pelicula 3
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[6].Id);
                    imgPelicula3.Image = imagenPelicula;
                    gbPelicula3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[6].Nombre;
                    lblGenero3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[6].Genero;
                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[6].EdadMinima == 0)
                    {
                        lblEdad3.Text = "Para todo el Público";
                    }
                    else lblEdad3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[6].EdadMinima.ToString();
                    lblDuracion3.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[6].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[6]);

                    //Pelicula 4
                    AsignarImagenes(formMultiplexOrigen.cineMultiplex.L_peliculas[7].Id);
                    imgPelicula4.Image = imagenPelicula;
                    gbPelicula4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[7].Nombre;
                    lblGenero4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[7].Genero;
                    if (formMultiplexOrigen.cineMultiplex.L_peliculas[7].EdadMinima == 0)
                    {
                        lblEdad4.Text = "Para todo el Público";
                    }
                    else lblEdad4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[7].EdadMinima.ToString();
                    lblDuracion4.Text = formMultiplexOrigen.cineMultiplex.L_peliculas[7].Duracion.ToString();

                    formMultiplexOrigen.cineMultiplex.L_peliculasActivas.Add(formMultiplexOrigen.cineMultiplex.L_peliculas[7]);

                    grupoPelicula--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ActualizarCartelera: " + ex);
            }
        }

        private void buttonActualizarCartelera_Click(object sender, EventArgs e)
        {
            ActualizarCartelera();
            formMultiplexOrigen.dgvFunciones.DataSource = null;
            formMultiplexOrigen.dgvFunciones.DataSource = l_reset;
            formMultiplexOrigen.dgvFunciones.Refresh();
            formMultiplexOrigen.CargarDatosFunciones();
        }
    }
}
