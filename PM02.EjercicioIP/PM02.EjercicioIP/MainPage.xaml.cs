using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02.EjercicioIP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Operaciones_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageOperaciones());
        }

        private async void Envio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageDatos());
        }
    }
}
