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
    public partial class NavegationMenu : TabbedPage
    {
        public NavegationMenu ()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void BtnRecordario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationRecordatorio());
        }

        private async void BtnPlanAlimenticio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlanAlimenticio());

        }

        private async void BtnCalculoIMC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationIMC());
        }

        private async void BtnContadorDePasos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavegationPasos());
        }

    }
}