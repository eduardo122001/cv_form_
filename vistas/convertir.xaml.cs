using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace form.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class convertir : ContentPage
    {
        public convertir(string nombre, string fecha, string profesion, string nacionalidades, string nivelSeleccionado, string lenguaje, string habilidad, string perfil)
        {   
            InitializeComponent();
            fnombre.Text = nombre;
            fnacimiento.Text = fecha;
            focupacion.Text = profesion;
            fnacionalidad.Text = nacionalidades;
            fnivel.Text = nivelSeleccionado;
            flenguaje.Text = lenguaje;
            fhabilidad.Text = habilidad;
            fperfil.Text = perfil;
        }
    }
}