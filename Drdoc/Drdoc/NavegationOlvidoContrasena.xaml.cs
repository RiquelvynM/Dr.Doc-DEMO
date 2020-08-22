using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Drdoc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavegationOlvidoContrasena : TabbedPage
    {
        public NavegationOlvidoContrasena ()
        {
            InitializeComponent();
        }

        private async void BtnEnviarCodigo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegacionRegistro());
        }
    }
}