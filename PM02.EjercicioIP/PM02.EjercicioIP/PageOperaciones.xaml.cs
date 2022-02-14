using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02.EjercicioIP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOperaciones : ContentPage
    {
        public PageOperaciones()
        {
            InitializeComponent();
        }

        private void Button_suma(object sender, EventArgs e)
        {
            var n1 = double.Parse(num1.Text);
            var n2 = double.Parse(num2.Text);
            var resultado = n1 + n2;

            res.Text = resultado.ToString();

        }
    }
}