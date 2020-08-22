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
    public partial class PlanAlimenticio : TabbedPage
    {
        public PlanAlimenticio ()
        {
            InitializeComponent();
        }

        private async void BtnFruta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationFrutas());
        }

        private async void BtnVerduras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationVerduras());
        }

        private async void BtnCarnes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationCarnes());

        }
    }
}