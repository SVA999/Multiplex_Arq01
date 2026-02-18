using b_Multiplex.Eventos;
using b_Multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace b_Multiplex.Clases



public class Cadena : IServicio
{

    private string nombre;
    private Multiplex l_multiplex;
    private IServicios l_servicios;




    // =========================
    // Constructor con inyección de dependencias
    // =========================
    public Cadena(string nombre, Multiplex multiplex, IServicios servicios)
    {

        this.nombre = nombre;
        this.l_multiplex = multiplex;
        this.l_servicios = servicios;

    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public Multiplex Multiplex
    {
        get => l_multiplex;
        set => l_multiplex = value ?? throw new ArgumentNullException(nameof(value));
    }

    public IServicios Servicios
    {
        get => l_servicios;
        set => l_servicios = value ?? throw new ArgumentNullException(nameof(value));
    }
}

