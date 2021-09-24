using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppLanternaNoturno
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            bntOnOff.Source = ImageSource.FromResource("AppLanternaNoturno.Image.botao-desligado.jpg");
        }
    }
}
