using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Drdoc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();

        }

        private async void BtnNavegationMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationMenu());
        }

        private async void BtnNavegationRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegacionRegistro());

        }

        private async void BtnOlvidoContrasena_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationOlvidoContrasena());
        }
    }
}

