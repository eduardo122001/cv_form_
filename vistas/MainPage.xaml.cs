using form.vistas;
using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace form
{
    public partial class MainPage : ContentPage
    { string nacionalidad=string.Empty;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_next_Clicked(object sender, EventArgs e)
        {
            string nombre = nombres.Text;
            string  fecha =fechas.Text;
            string profesion=profesions.Text;
            string nacionalidades=nacionalidad;

            string nivelSeleccionado = string.Empty;
            if (Bajas.IsChecked)
            {
                nivelSeleccionado = "Baja";
            }
            else if (Medias.IsChecked)
            {
                nivelSeleccionado = "Media";
            }
            else if (Altas.IsChecked)
            {
                nivelSeleccionado = "Alta";
            }

            string lenguaje=lenguajes.Text;
            string habilidad=habilidades.Text;
            string perfil=perfils.Text;
            
            Navigation.PushAsync(new convertir(nombre,fecha,profesion,nacionalidades,nivelSeleccionado,lenguaje,habilidad,perfil));
        }

        private void select_nac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
             nacionalidad = (string)picker.SelectedItem;
        }
    }
}
